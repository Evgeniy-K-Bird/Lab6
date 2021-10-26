using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любое предложение:");
            string s = Console.ReadLine();
            s = s.Replace(" ","");
            s = s.ToLower();
            char[] arr;
            arr = s.ToArray();
            Array.Reverse(arr);
            string s1 = String.Concat<char>(arr);
            if (s==s1)
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
