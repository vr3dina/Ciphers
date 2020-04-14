using System.Numerics;
using System.Security.Cryptography;

namespace Ciphers
{
    public static class BigIntegerExtensions
    {
        /// <summary>
        /// Miller-Rabin primality test
        /// </summary>
        /// <param name="n">a number</param>
        /// <param name="iters">iteration count</param>
        /// <returns></returns>
        public static bool IsProbablePrime(this BigInteger n, int iters = 1000)
        {
            if (n == 2 || n == 3)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;

            BigInteger d = n - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] bytes = new byte[n.ToByteArray().LongLength];
                BigInteger a;

                for (int i = 0; i < iters; i++)
                {
                    do
                    {
                        rng.GetBytes(bytes);
                        a = new BigInteger(bytes);
                    }
                    while (a < 2 || a >= n - 2);

                    BigInteger x = BigInteger.ModPow(a, d, n);
                    if (x == 1 || x == n - 1)
                        continue;

                    for (int r = 1; r < s; r++)
                    {
                        x = BigInteger.ModPow(x, 2, n);
                        if (x == 1)
                            return false;
                        if (x == n - 1)
                            break;
                    }

                    if (x != n - 1)
                        return false;
                }
            }
            return true;
        }
    }
}
