using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;

namespace BlueSquareBugTracker.Core.Security
{
    public class Crypt
    {   
        public static string Hash(string password)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Encoding.ASCII.GetBytes("ceb20772e0c9d240c75eb26b0e37abee"),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
        }        
    }
}
