using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Angka 1 = ");
            int angka1 = int.Parse(Console.ReadLine());

            Console.Write("Angka 2 = ");
            int angka2 = int.Parse(Console.ReadLine());

            Console.Write(angka1);
            Console.Write("+");
            Console.Write(angka2);
            Console.Write("=");
            Console.WriteLine(angka1 + angka2);

            Console.Write(angka1);
            Console.Write("-");
            Console.Write(angka2);
            Console.Write("=");
            Console.WriteLine(angka1 - angka2);

            Console.Write(angka1);
            Console.Write("*");
            Console.Write(angka2); 
            Console.Write("=");
            Console.WriteLine(angka1 * angka2);

            Console.Write(angka1);
            Console.Write(":");
            Console.Write(angka2);
            Console.Write("=");
            Console.WriteLine(angka1 / angka2);
        }
    }
}
