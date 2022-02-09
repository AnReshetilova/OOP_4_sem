using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class Calculator
    {
        public static string FirstArg { get; set; }
        public static string  SecondArg { get; set; }

        public static Operations Operation { get; set; }
        public static Styles Style { get; set; }

        public static string GetResult()
        {
            string result = "";
            int temp = 0;
            switch (Operation)
            {
                case Operations.and:
                    result = And();
                    break;
                case Operations.or:
                    result = Or();
                    break;
                case Operations.not:
                    result = Not();
                    break;
                default:
                    return null;
            }

            switch (Style)
            {
                case Styles.binary:
                    return result;
                case Styles.dec:
                    return Convert.ToInt32(result, 2).ToString();
                case Styles.hexadec:
                    temp = Convert.ToInt32(result, 2);
                    return Convert.ToString(temp, 16);
                case Styles.octal:
                    temp = Convert.ToInt32(result, 2);
                    return Convert.ToString(temp, 8);
                default:
                    return null;
            }
        }

        static string And()
        {
            string result = "";
            for (int i = 0; i < FirstArg.Length; i++)
            {
                if (FirstArg[i] == '1' && SecondArg[i] == '1')
                {
                    result += '1';
                }
                else
                {
                    result += '0';
                }
            }

            return result;
        }

        static string Or()
        {
            string result = "";
            for (int i = 0; i < FirstArg.Length; i++)
            {
                if (FirstArg[i] == '1' || SecondArg[i] == '1')
                {
                    result += '1';
                }
                else
                {
                    result += '0';
                }
            }

            return result;
        }

        static string Not()
        {
            string result = "";
            foreach(var el in FirstArg)
            {
                if (el == '1')
                {
                    result += '0';
                }
                else
                {
                    result += '1';
                }
            }

            return result;
        }
    }
}
