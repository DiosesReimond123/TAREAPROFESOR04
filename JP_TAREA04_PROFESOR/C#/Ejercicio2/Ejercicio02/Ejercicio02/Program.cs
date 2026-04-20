Console.WriteLine(" === Menú de operaciones === ");
Console.WriteLine("1. Calcular area de un circulo");
Console.WriteLine("2. Calcular area de un cuadrado");
Console.WriteLine("3. Calcular area de un triangulo");
Console.WriteLine("4. Salir");
Console.Write("Seleccione una opción (1-4): ");
int opcion = int.Parse(Console.ReadLine());
switch (opcion) // evalua el valor de la variable
{

    case 1:
        Console.WriteLine("Área circulo = p x r2");
        break; // obligatorio en C# - termina el case
    case 2:
        Console.WriteLine("Area cuadrado = lado'");
        break;
    case 3:
        Console.WriteLine("Area triangulo = (base x altura) /2");
        break;
    case 4:
        Console.WriteLine("Saliendo del programa ... ");
        break;
    default: // si ningún case coincide
        Console.WriteLine("Opción inválida. Ingresa un número del 1 al 4.");
        break;
}