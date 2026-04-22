Console.Write("ingrese el peso en kg: ");
double peso = double.Parse(Console.ReadLine());

Console.Write("ingrese la estatura en metros: ");
double estatura = double.Parse(Console.ReadLine());

// Calcular el IMC usando la función de potencia
double imc = peso / Math.Pow(estatura, 2); // ¿que valor se eleva al cuadrado?

// Redondear a 2 decimales para mostrar
double imcRed = Math.Round(imc, 2); // cantidad de decimales

Console.WriteLine($"IMC: {imcRed}");

// Clasificación por rangos (condicion multiple)
if (imc < 18.5)
{
    Console.WriteLine("Bajo peso");
}
else if (imc < 25) { // limite superior de 'normal'
    Console.WriteLine("Normal");
}else if (imc < 30)
{
    Console.WriteLine("Sobrepeso"); //clasificacion correspondiente
}
else
{
    Console.WriteLine("Obesidad");
}
