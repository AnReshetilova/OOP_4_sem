using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab2.Classes
{
    static class Bloodhound
    {
        public static List<Product> FindName(string name, List<Product> products, RegexOptions op, int length)
        {
            string pattern = @"(\w*)" + name + @"(\w*)";
            List<Product> result = new List<Product>();

            foreach (var el in products)
            {
                if (Regex.IsMatch(el.Name, pattern, op) && el.Name.Length <= length)
                {
                    result.Add(el);
                }
            }

            return result;
        }

        public static List<Product> FindType(List<Product> products, string type)
        {
            List<Product> result = new List<Product>();
            foreach (var el in products)
            {
                if (el.Type == type)
                {
                    result.Add(el);
                }
            }

            return result;
        }

        public static List<Product> FindSize(List<Product> products, string weight)
        {
            (int min, int max) iWeight;
            iWeight.min = Int32.Parse(weight.Split("-")[0]);
            iWeight.max = Int32.Parse(weight.Split("-")[1]);

            List<Product> result = new List<Product>();
            foreach (var el in products)
            {
                if (el.Weight > iWeight.min && el.Weight < iWeight.max)
                {
                    result.Add(el);
                }
            }

            return result;
        }
    }
}
