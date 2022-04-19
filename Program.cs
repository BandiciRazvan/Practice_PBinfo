using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_PBinfo
{
    internal class Program
    {
        static void Main(string[] args)
            // Problema 633 - Diferenta dintre cate numere pare vs numere impare exista intr-un vector 
        {
            Console.Write("introduceti numarul de element, n: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] b = Console.ReadLine().Split(' ');
            int par = 0;
            int impar = 0;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(b[i]);
                if (v[i] % 2 == 0)
                    par++;
                else 
                    impar++;

            }
            int c = Math.Abs(par - impar);
            Console.WriteLine(c);
        }
    }
}
