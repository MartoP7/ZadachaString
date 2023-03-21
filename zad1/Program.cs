using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Input two strings: ");
            Console.Write("string 1 = ");
            string str1 = Console.ReadLine();
            char[] s1chars = str1.ToCharArray();

            Console.Write("string 2 = ");
            string str2 = Console.ReadLine();
            char[] s2chars = str2.ToCharArray();

            Console.WriteLine($"Sum = {Execute(str1, str2, s1chars, s2chars)}"); 

        }

        private static int Execute(string str1, string str2, char[] s1chars, char[] s2chars)
        {
            int length = Math.Max(str1.Length, str2.Length);

            int[] s1code = new int[length];
            int[] s2code = new int[length];

            for (int i = 0; i < str1.Length; i++)
            {
                s1code[i] = (int) s1chars[i];
            }
            for (int i = 0; i < str2.Length; i++)
            {
                s2code[i] = (int) s2chars[i];
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(" ", s1code));
            Console.WriteLine(string.Join(" ", s2code));
            Console.WriteLine();


            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = s1code[i] * s2code[i];
            }

            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                sum += result[i];
            }


            //Console.WriteLine(string.Join(" ", result));

            return sum;
        }
    }
}
