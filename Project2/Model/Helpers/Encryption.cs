using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Project2.Model.Helpers
{
    public static class Encryption
    {
        public static string pass(string pass)
        {
            byte[] Salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            // Derive a 256-bit Subkey (Use HMACSHA256 With 100,000 Iterations)
            string password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: pass,
                salt: Salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return password;
        }
    }
}
