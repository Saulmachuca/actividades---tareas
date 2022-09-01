using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 1;

            while (op == 1)
            {

                double r, hh, area, volumen;
                Console.Write("digite el valor de r");
                r = float.Parse(Console.ReadLine());
                Console.Write("digite el valor de h");
                hh = float.Parse(Console.ReadLine());
                area = (2 * 3.1416) * (r * (hh + r));
                volumen = 3.1416 * (r * r) * hh;
                Console.Write("");
                Console.Write("el are es igual a " + area + " Y el volumen es de " + volumen);

                Console.Write("digite 1 si quiere repetir el procesos y 2 si no ");
                op = int.Parse(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}