using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, minutos, segundos;
            Console.WriteLine("ingresa las horas:");
            hora = int.Parse(Console.ReadLine());

            minutos = hora * 60;
            segundos = minutos * 60;

            Console.Write("la cntidad de horas es de:" + hora);
            Console.Write("minutos es:" + minutos);
            Console.Write("segundos es:" + segundos);


            /// ejercicio2
            int a, b, c, p, h;
            Console.WriteLine("digite el valor de base");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("digite altura");
            Console.WriteLine("digite el valor de c");
            c = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            a = b * h;
            p = a + b + c;
            Console.WriteLine("el valor del area es" + a + "y el perimetro es" + p);

            ///ejercicio 3
            double r, hh, area, volumen;
            r = float.Parse(Console.ReadLine());
            hh = float.Parse(Console.ReadLine());
            area = (2 * 3.14) * (r * (h + r));
            volumen = 3.1416 * (r * r) * hh;
            Console.WriteLine("");
            Console.Write("es el area  igual" + area + " y el volukmen es de:" + volumen);

            ///ejercicio 4
            Console.Write("ingrese el primer valor: \n");
            float Primero = float.Parse(Console.ReadLine());

            Console.Write("ingrese la altura: \n");
            float segundo = float.Parse(Console.ReadLine());

            float suma = Primero + segundo;
            float resta = Primero - segundo;
            float division = Primero / segundo;
            float multi = Primero * segundo;

            Console.Write("la suma es de: " + suma + ", la resta es de: " + resta + ", la division es de: " + division + ", la multiplicacion es de: " + multi);

            ///ejercicio 5

            Console.Write("ingrese su nombre: \n");
            string nombre = Console.ReadLine();

            Console.Write("ingrese su edad: \n");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("ingrese el peso: \n");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("ingrese la estatura: \n");
            float estatura = float.Parse(Console.ReadLine());

            Console.Write("tipo de sangre: \n");
            string TipoDeSangre = Console.ReadLine();

            Console.Write("--resumen de los datos--\n");
            Console.Write("nombre: " + nombre + " edad: " + edad + " peso: " + peso + " estatura: " + estatura + " tipo de sangre: " + TipoDeSangre);
            Console.Read();
        }
    }
}
