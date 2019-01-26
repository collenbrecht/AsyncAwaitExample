using CryptSharp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attentia.Dots.AsyncAwaitExample
{
    public class Dishes
    {
        public string CleanDishes(string secret, string salt)
        {
            var keyBytes = Encoding.UTF8.GetBytes(secret);
            var saltBytes = Encoding.UTF8.GetBytes(salt);
            var cost = 262144;
            var blockSize = 8;
            var parallel = 1;
            var maxThreads = (int?)null;
            var derivedKeyLength = 128;

            var bytes = SCrypt.ComputeDerivedKey(
                keyBytes, saltBytes, cost, blockSize, parallel, maxThreads, derivedKeyLength
                );

            Console.WriteLine($"cleaned some dishes for input '{secret}' ");
            return Convert.ToBase64String(bytes);

        }
    }
}
