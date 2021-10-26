using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любое предложение.");
            string s = Console.ReadLine();
            string max="";
            string[] slova = s.Split(' ');
            for (int i = 1; i < slova.Length; i++)
                if (slova[i].Length > max.Length)
                    max = slova[i];
             Console.WriteLine("Самое длинное слово: {0}", max);
            Console.ReadKey();
        }
    }
}
