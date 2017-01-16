using System;
using System.Security.Cryptography;


namespace PasswordClassLibrary
{
    static public class PasswordClass
    {
        enum passwordType
        {
            digits,
            lowerCaseLetters,
            upperCaseLetters,
            digitsLowerCaseLetters,
            digitsUpperCaseLetters,
            lowerAndUpperCaseLetters,
            all
        }


        // NOTE: in these functions parameters digit1, digit2 describe
        // the range of digits that will be in password.In the same way
        // lowLetter1,lowLetter2 and upLetter1,upLette2 describe the range of lowercase letters
        public static string pinCodeWithDigits(int length, int digit1, int digit2)
        {
            string str = pinCodes(length,1,passwordType.digits,digit1,digit2);
            return str;
        }

        public static string pinCodeWithLowerCaseLetters(int length, char lowLetter1, char lowLetter2)
        {

            if (!(char.IsLower(lowLetter1) && char.IsLower(lowLetter2)))
                 throw new ArgumentOutOfRangeException("Both letters are not in same case or arguments are not letters");  
            
            string str = pinCodes(length,1,passwordType.lowerCaseLetters, lowletter1: lowLetter1,lowletter2: lowLetter2);
            return str;
        }

        public static string pinCodeWithUpperCaseLetters(int length, char upLetter1, char upLetter2)
        {

            if (!(char.IsUpper(upLetter1) && char.IsUpper(upLetter2)))
                throw new ArgumentOutOfRangeException("Both letters are not in same case or arguments are not letters");

            string str = pinCodes(length, 1, passwordType.upperCaseLetters, upLetter1: upLetter1, upLetter2: upLetter2);
            return str;
        }

        public static string pinCodeWithDigitsLowerCaseLetters(int length, int digit1, int digit2, char lowLetter1, char lowLetter2)
        {
            if (!(char.IsLower(lowLetter1) && char.IsLower(lowLetter2)))
                throw new ArgumentOutOfRangeException("Both letters are not in same case or arguments are not letters");

            string str = pinCodes(length, 1, passwordType.digitsLowerCaseLetters, digit1,digit2,
                                                    lowletter1: lowLetter1, lowletter2: lowLetter2
                                                                                                   );
            return str;
        }

        public static string pinCodeWithDigitsUpperCaseLetters(int length, int digit1, int digit2, char upLetter1, char upLetter2)
        {
            if (!(char.IsUpper(upLetter1) && char.IsUpper(upLetter2)))
                throw new ArgumentOutOfRangeException("Both letters are not in same case or arguments are not letters");

            string str = pinCodes(length, 1, passwordType.digitsUpperCaseLetters, digit1, digit2,
                                                    upLetter1: upLetter1, upLetter2: upLetter2
                                                                                                   );
            return str;
        }


        public static string pinCodeWithDifferentCaseLetters(int length, char lowletter1, char lowletter2, char upLetter1, char upLetter2)
        {

            if (!(char.IsUpper(upLetter1) && char.IsUpper(upLetter2) || char.IsLower(lowletter1) && char.IsLower(lowletter2)))
                throw new ArgumentOutOfRangeException("Both letters are not in same case or arguments are not letters");

            string str = pinCodes(length, 1, passwordType.lowerAndUpperCaseLetters,
                                    upLetter1: upLetter1, upLetter2: upLetter2,
                                    lowletter1:lowletter1,lowletter2:lowletter2);
            return str;
        }

        public static string pinCodeWithDigitsLetters(int length, int digit1 , int digit2 ,
                                                            char lowletter1 , char lowletter2 ,
                                                            char upLetter1 , char upLetter2)
        {
            if (!(char.IsUpper(upLetter1) && char.IsUpper(upLetter2) || char.IsLower(lowletter1) && char.IsLower(lowletter2)))
                throw new ArgumentOutOfRangeException("Both letters are not in same case or arguments are not letters");

            string str = pinCodes(length, 1, passwordType.all,
                                    digit1: digit1, digit2: digit2,
                                    upLetter1: upLetter1, upLetter2: upLetter2,
                                    lowletter1: lowletter1, lowletter2: lowletter2);
            return str;
        }






        private static string pinCodes(int length, int count, passwordType type,
                                                                int digit1 = 0,int digit2 = 0,
                                                                char lowletter1 = '-', char lowletter2 = '-',
                                                                char upLetter1 = '-', char upLetter2 = '-')
        {
            using (var rng = new RNGCryptoServiceProvider())
            {

                int typeCount = 1;
                int diap1 = -1, diap2 = -1;
                int diap3 = -1, diap4 = -1;
                int diap5 = -1, diap6 = -1;

                switch (type)   
                {
                    case passwordType.digits:
                        {
                            diap1 = digit1 <= digit2 ? digit1 + 48 : digit2 + 48;
                            diap2 = digit1 >= digit2 ? digit1 + 48 : digit2 + 48;
                        }
                        break;
                    case passwordType.lowerCaseLetters:
                        {
                            diap1 = lowletter1 <= lowletter2 ? lowletter1 : lowletter2;
                            diap2 = lowletter1 >= lowletter2 ? lowletter1 : lowletter2;
                        }
                        break;
                    case passwordType.upperCaseLetters:
                        {
                            diap1 = upLetter1 <= upLetter2 ? upLetter1 : upLetter2;
                            diap2 = upLetter1 >= upLetter2 ? upLetter1 : upLetter2;
                        }
                        break;
                    case passwordType.digitsLowerCaseLetters:
                        {
                            diap1 = digit1 <= digit2 ? digit1 + 48 : digit2 + 48;
                            diap2 = digit1 >= digit2 ? digit1 + 48 : digit2 + 48;

                            diap3 = lowletter1 <= lowletter2 ? lowletter1 : lowletter2;
                            diap4 = lowletter1 >= lowletter2 ? lowletter1 : lowletter2;

                            typeCount = 2;
                        }
                        break;
                    case passwordType.digitsUpperCaseLetters:
                        {
                            diap1 = digit1 <= digit2 ? digit1 + 48 : digit2 + 48;
                            diap2 = digit1 >= digit2 ? digit1 + 48 : digit2 + 48;

                            diap3 = upLetter1 <= upLetter2 ? upLetter1 : upLetter2;
                            diap4 = upLetter1 >= upLetter2 ? upLetter1 : upLetter2;

                            typeCount = 2;
                        }
                        break;
                    case passwordType.lowerAndUpperCaseLetters:
                        {

                            diap1 = lowletter1 <= lowletter2 ? lowletter1 : lowletter2;
                            diap2 = lowletter1 >= lowletter2 ? lowletter1 : lowletter2;

                            diap3 = upLetter1 <= upLetter2 ? upLetter1 : upLetter2;
                            diap4 = upLetter1 >= upLetter2 ? upLetter1 : upLetter2;

                            typeCount = 2;
                        }
                        break;
                    case passwordType.all:
                        {
                            diap1 = digit1 <= digit2 ? digit1 + 48 : digit2 + 48;
                            diap2 = digit1 >= digit2 ? digit1 + 48 : digit2 + 48;

                            diap3 = lowletter1 <= lowletter2 ? lowletter1 : lowletter2;
                            diap4 = lowletter1 >= lowletter2 ? lowletter1 : lowletter2;

                            diap5 = upLetter1 <= upLetter2 ? upLetter1 : upLetter2;
                            diap6 = upLetter1 >= upLetter2 ? upLetter1 : upLetter2;

                            typeCount = 3;
                        }
                        break;
                    default:
                        break;
                }


                string[] result = new string[count];
                var data = new byte[4];
                rng.GetBytes(data);

                var seed = BitConverter.ToInt32(data, 0);
                var rnd = new Random(seed);

                string str = string.Empty;
                int numberOrLetter;
                int seed1;
                Random ran;

                if (typeCount == 1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {

                            str += (char)rnd.Next(diap1, diap2 + 1);
                        }
                    }
                }

                if (typeCount == 2)
                {
                    for (int i = 0; i < count; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            rng.GetBytes(data);
                            seed1 = BitConverter.ToInt32(data, 0);
                            ran = new Random(seed1);

                            numberOrLetter = ran.Next(0, 2);

                            if (numberOrLetter == 0)
                                str += (char)rnd.Next(diap1, diap2 + 1);
                            else
                                str += (char)rnd.Next(diap3, diap4 + 1);
                        }
                    }
                }
                if (typeCount == 3)
                {
                    for (int i = 0; i < count; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            rng.GetBytes(data);
                            seed1 = BitConverter.ToInt32(data, 0);
                            ran = new Random(seed1);

                            numberOrLetter = ran.Next(0, 3);

                            if (numberOrLetter == 0)
                                str += (char)rnd.Next(diap1, diap2 + 1);
                            if (numberOrLetter == 1)
                                str += (char)rnd.Next(diap3, diap4 + 1);
                            if (numberOrLetter == 2)
                                str += (char)rnd.Next(diap5, diap6 + 1);
                        }
                    }
                }

                return str;
            }
        }
    }
}
