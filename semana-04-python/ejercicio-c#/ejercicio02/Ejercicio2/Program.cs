using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********menu de operaciones*******");
            Console.WriteLine("1. calcular area de un circulo");
            Console.WriteLine("2. calcular area de un cuadrado");
            Console.WriteLine("3. calcular area de un triangulo");
            Console.WriteLine("4. salir");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion) //evaluar el valor  de la variable
            {
                case 1:
                    Console.WriteLine("area de un circulo = p * r");
                    break; //obligatorio en c# - termina el case
                case 2: 
                    Console.WriteLine("area de un cuadrado"
            }

        }
    }
}
