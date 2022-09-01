using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculas_horas
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos;
            Console.WriteLine("digite las horas ");
            horas = int.Parse(Console.ReadLine());

            minutos = horas * 60;
            segundos = minutos * 60;

            Console.Write("La cantidad de horas es de..." + horas);
            Console.Write("");
            Console.Write(" minutos " + minutos);
            Console.Write("");
            Console.Write(" segundos " + segundos);
            Console.Write("");

            // ejercicio 2

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

            // ejercicio 3

            double r, hh, area, volumen;
            Console.Write("digite el valor de r");
            r = float.Parse(Console.ReadLine());
            Console.Write("digite el valor de h");
            hh = float.Parse(Console.ReadLine());
            area = (2 * 3.1416) * (r * (hh + r));
            volumen = 3.1416 * (r * r) * hh;
            Console.Write("");
            Console.Write("el are es igual a " + area + " Y el volumen es de " + volumen);

            //ejercicio 4
            double var1, var2, rf;
            Console.Write("digite el valor 1 ");
            var1 = double.Parse(Console.ReadLine());
            Console.Write("digite el valor 2 ");
            var2 = double.Parse(Console.ReadLine());
            rf = var1 + var2;
            Console.Write(" el valor de la suma es " + rf);
            rf = var1 * var2;
            Console.Write(" el valor de la multiplicacion es " + rf);
            rf = var1 - var2;
            Console.Write(" el valor de la resta es " + rf);
            rf = var1 % var2;
            Console.Write(" el valor de la divicion es " + rf);
            // ejercicio 5
            string nombre, edad, peso, estatura, tipo_sangre;
            Console.Write("digite el nombre ");
            nombre = Console.ReadLine();
            Console.Write("digite la edad ");
            edad = Console.ReadLine();
            Console.Write("digite el peso ");
            peso = Console.ReadLine();
            Console.Write("digite estatura ");
            estatura = Console.ReadLine();
            Console.Write("digite el tipo de sangre ");
            tipo_sangre = Console.ReadLine();
            Console.Write("los datos son los siguientes: ");
            Console.Write(nombre + "\n" + edad + "\n" + peso + "\n" + estatura + "\n" + tipo_sangre);

            Console.Read();


        }
    }
}
