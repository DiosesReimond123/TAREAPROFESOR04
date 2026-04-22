        Console.Write("Ingrese el promedio (0-20): ");
        double promedio = double.Parse(Console.ReadLine());

        if (promedio < 0 || promedio > 20)
        {
            Console.WriteLine("Valor inválido");
        }
        else if (promedio <= 5)
        {
            Console.WriteLine("Deficiente");
        }
        else if (promedio <= 10)
        {
            Console.WriteLine("Regular");
        }
        else if (promedio <= 14)
        {
            Console.WriteLine("Bueno");
        }
        else
        {
            Console.WriteLine("Excelente");
        }
