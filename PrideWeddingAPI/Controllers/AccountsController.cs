using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using PrideWeddingAPI.Models;
using PrideWeddingAPI.Data;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PrideWeddingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfigurationSection _jwtSettings;
        private readonly WeddingDBContext db;



        public AccountsController(IMapper mapper, UserManager<User> userManager, IConfiguration configuration, WeddingDBContext context)
        {
            _mapper = mapper;
            _userManager = userManager;
            _jwtSettings = configuration.GetSection("JwtSettings");
            db = context;
        }


        [HttpGet("Test")]  //api/Accounts/Test
        public String Test()
        {

            return "accounts controller!!!";
        }




        //  [EnableCors("", "", "*")]
        [HttpGet("Home")]
        public String Home()
        {
            return "Pride Wedding Service Providers";
        }

        [HttpPost("ClientRegister")]  // api/Accounts/ClientRegister
        public async Task<ActionResult> Register(ClientRegistration userModel)
        {
            var user = _mapper.Map<User>(userModel);
            var client = _mapper.Map<Client>(userModel);

            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                return Ok(result.Errors);
            }
            await _userManager.AddToRoleAsync(user, "Client");

            db.Clients.Add(client);
            db.SaveChanges();

            return StatusCode(201);
        }


        /*       [HttpPost("AdminRegister")]  // api/Accounts/AdminRegister
               public async Task<ActionResult> AdminRegister(AdminRegistrationModel userModel)
               {
                   var user = _mapper.Map<User>(userModel);
                   var result = await _userManager.CreateAsync(user, userModel.Password);
                   if (!result.Succeeded)
                   {
                       return Ok(result.Errors);
                   }
                   await _userManager.AddToRoleAsync(user, "Administrator");
                   return StatusCode(201);
               }
        */
        [HttpPost("VendorRegister")]  // api/Accounts/VendorRegister
        public async Task<ActionResult> VendorRegister(VendorRegistration userModel)
        {
            var user = _mapper.Map<User>(userModel);
            var vendor = _mapper.Map<Vendor>(userModel);

            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                return Ok(result.Errors);
            }
            await _userManager.AddToRoleAsync(user, "Vendor");

            db.Vendors.Add(vendor);
            db.SaveChanges();

            return StatusCode(201);
        }
        [HttpPost("Login")]  // api/Accounts/Login
        public async Task<IActionResult> Login(UserLogin userModel)
        {
            var user = await _userManager.FindByEmailAsync(userModel.Email);

            if (user != null && await _userManager.CheckPasswordAsync(user, userModel.Password))
            {
                var roles = await _userManager.GetRolesAsync(user);//**
                var signingCredentials = GetSigningCredentials();
                var claims = GetClaims(user);
                var tokenOptions = GenerateTokenOptions(signingCredentials, await claims);
                //var UEmail = User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.Name, StringComparison.InvariantCultureIgnoreCase));
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

        private async Task<List<Claim>> GetClaims(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email)
                //new Claim("Id", "110")
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