using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejeercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el peso en kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());

            //calcular el  IMC usando la funcion de potencia
            double imc = peso / Math.Pow(estatura, 2); //¿que valor se eleva al cuadrado?

            //redondear a 2 decimales para mostrar
            double imcred = Math.Round(imc, 2); //cantidad de decimales 

            Console.WriteLine($"IMC: {imcred}");

            //clasificacion por rangos (condicion multiple)
            if(imc < 18.5)
            {
                Console.WriteLine("bajo de peso");
            }
            else if (imc >= 18.5 && imc < 25) { //limite superior de 'normal'
                Console.WriteLine("normal");
            } else if (imc < 30)
            {
                Console.WriteLine("sobrepeso"); //clasificacion correspondiente
            }
            else
            {
                Console.WriteLine("obesidad");
            }
        }
    }
}
