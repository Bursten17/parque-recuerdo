using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API.Application.Contracts.Response.IdentityService;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using morcom_api.Application.Abstract;

namespace morcom_api.Infrastructure.Security
{
    public class JwtGeneretor : IJwtGenerator
    {
        private readonly SymmetricSecurityKey _key;
        public JwtGeneretor(IConfiguration config)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]));
        }

        public string createToken(UserResponse data)
        {
            //claims
            var claims = new List<Claim>()
            {
                // new Claim("n_id_user", data.n_id_user.ToString()),
                // new Claim("n_id_role", data.n_id_role.ToString())
            };

            //credentials siging 
            var creeds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            //PAYLOAD
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = creeds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}