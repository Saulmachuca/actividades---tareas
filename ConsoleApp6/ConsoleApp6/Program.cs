using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, op;
            int segundos, minutos;
            Console.WriteLine("digite el tiempo en horas");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("digite 1 siquiere ver los en minutos y 2 si es en segundo");
            op = int.Parse(Console.ReadLine());
            minutos = horas * 60;
            segundos = minutos * 60;

            if (op == 1)
            {
                Console.WriteLine("el valor en minutos es de " + minutos);

            }

            else if (op == 2)
            {
                Console.WriteLine("el valor en segundos es de " + segundos);
            }

            Console.ReadLine();
        }
    }
}