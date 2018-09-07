using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace gittest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature (e.g., 32F, 100C):\n");

            string s = Console.ReadLine();
            Regex reg = new Regex("^([-+]?[0-9]+)([CF])$");
            Regex regNum = new Regex("^[-+]?|[CF]");

            string type = s.Substring(s.Length-1);
            decimal inputNum = decimal.Parse(Regex.Replace(s, "^[-+]?|[CF]",""));
            int result = 0;

            if (reg.IsMatch(s))
            {
                if (type == "F")
                {
                    result = ((int)inputNum - 32) * 5 /9;
                    Console.WriteLine("{0} is {1}C", s, result);
                }
                else
                {
                    result = ((int)inputNum * 9 / 5) + 32;
                    Console.WriteLine("{0} is {1}F", s, result);
                }
            }
            else
            {
                Console.WriteLine("Expecting a number followed by \"C\" or \"F\",\n");
                Console.WriteLine("so I don't understand {0}.\n", s);
            }

        }
    }
}
