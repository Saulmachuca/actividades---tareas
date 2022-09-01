using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine(" digite el numero de veces que decea repetir el proceso  ");
            op = int.Parse(Console.ReadLine());
            for (int i = 0; i <= op; i++)
            {
                int a, b, c, p, h;
                Console.Write("digite el valor de base");
                Console.Write("");
                b = int.Parse(Console.ReadLine());
                Console.Write("");
                Console.Write("digite el valor de la altura");
                Console.Write("");
                Console.Write("digite el valor de c");
                Console.Write("");
                c = int.Parse(Console.ReadLine());
                Console.Write("digite el valor de h");
                h = int.Parse(Console.ReadLine());
                a = b * h;
                p = a + b + c;
                Console.WriteLine("el valor del Area es " + a + " y el de el perimetro " + p);
            }

            Console.ReadLine();
        }
    }
}