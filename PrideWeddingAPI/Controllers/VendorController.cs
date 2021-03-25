
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PrideWeddingAPI.Data;
using PrideWeddingAPI.Models;

namespace PrideWeddingPlanners.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Vendor> _userManager;
        private readonly IConfigurationSection _jwtSettings;

        public VendorController(IMapper mapper, UserManager<Vendor> userManager, IConfiguration configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _jwtSettings = configuration.GetSection("JwtSettings");
        }

        [Authorize(Roles = "Visitor")]
        [HttpGet("Test")]
        public String Test()
        {
            return "vendorsController";
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register(VendorRegistration userModel)
        {
            var user = _mapper.Map<Vendor>(userModel);
            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                return Ok(result.Errors);
            }
            await _userManager.AddToRoleAsync(user, "Visitor");

            return StatusCode(201);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(VendorLogin userModel)
        {
            var Vendor = await _userManager.FindByEmailAsync(userModel.Email);

            if (Vendor != null && await _userManager.CheckPasswordAsync(Vendor, userModel.Password))
            {
                var signingCredentials = GetSigningCredentials();
                var claims = GetClaims(Vendor);
                var tokenOptions = GenerateTokenOptions(signingCredentials, await claims);
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(token);
            }
            return Unauthorized("Invalid Authentication");

        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_jwtSettings.GetSection("securityKey").Value);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _jwtSettings.GetSection("validIssuer").Value,
                audience: _jwtSettings.GetSection("validAudience").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings.GetSection("expiryInMinutes").Value)),
                signingCredentials: signingCredentials);

            return tokenOptions;
        }

        private async Task<List<Claim>> GetClaims(Vendor user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email)
            };
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
    }
}
