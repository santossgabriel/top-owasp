using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Shop.Api.Auth
{
    public static class JwtSecurityKey
    {
        private const string SECRET = "!@#$%&*()SecretKey!WebApi!@#$%&*()";
        public static SymmetricSecurityKey Create()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SECRET));
        }
    }
}