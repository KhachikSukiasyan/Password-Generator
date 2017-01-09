using System;
using System.Security.Cryptography;

namespace PasswordClassLibrary
{
    static public class PasswordClass
    {
        public static string NewPinCode(int length)
        {
             using (var rng = new RNGCryptoServiceProvider())
             {
                var data = new byte[4];
                rng.GetBytes(data);
                var seed = BitConverter.ToInt32(data, 0);
                var rnd = new Random(seed);

                string str = string.Empty;
                int numberOrLetter;
                int seed1;
                Random ran;

                for (int j = 0; j < length; j++)
                {
                   rng.GetBytes(data);
                   seed1 = BitConverter.ToInt32(data, 0);
                   ran = new Random(seed1);

                   numberOrLetter = ran.Next(0,2);
                   if(numberOrLetter == 0)
                       str += (char)rnd.Next(48, 58); // number
                   else
                       str += (char)rnd.Next(65, 71);// letter A - F
                }

                return str;
            }
        }
    }
}
