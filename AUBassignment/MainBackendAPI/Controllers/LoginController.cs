using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace MainBackendAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Post()
        {


            var accesstoken = GenerateJwtToken("", 1);
            return Ok(new { isAuthenticated = true, AccessToken = accesstoken });


        }


        // ///////////////////////

        private string GenerateJwtToken(string UserName, long UserID)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("sG3reGHJ$%!QWgjgfxD$#T&*jfs234WEtgjtsqq@"); //  secret key
            var tokenDescriptor = new SecurityTokenDescriptor                               
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, UserName),
                    new Claim("UserID",UserID.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(1), // Token expiration time
                Issuer = "my-issuer",
                Audience = "my-audience",
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


        /// ///////////////////////////


        public class LoginRequest
        {
            public long UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}