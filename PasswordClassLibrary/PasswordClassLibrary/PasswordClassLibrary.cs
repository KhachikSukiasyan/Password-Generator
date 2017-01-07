using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordClassLibrary
{
    public class PasswordClassLibrary
    {
        public static void NewPinCode(int length,int count)
        {
            for (int i = 0; i < count; i++)
            {
                using (var rng = new RNGCryptoServiceProvider())
                {
                    var data = new byte[4];

                    rng.GetBytes(data);

                    var seed = BitConverter.ToInt32(data, 0);

                    var rnd = new Random(seed);


                    string str = string.Empty;
                    int k;

                    for (int j = 0; j < length; j++)
                    {
                        rng.GetBytes(data);

                        var seed1 = BitConverter.ToInt32(data, 0);

                        var ran = new Random(seed1);


                        k = ran.Next(0,2);
                        if(k == 0)
                            str += (char)rnd.Next(48, 58); // number
                        else
                            str += (char)rnd.Next(65, 71);// letter A - F
                    }

                    Console.WriteLine(str);
                }
            }

        }

    }
}
