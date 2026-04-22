        // Entradas
        Console.Write("Ingrese examen parcial: ");
        double parcial = double.Parse(Console.ReadLine());
        Console.Write("Ingrese examen final: ");
        double final = double.Parse(Console.ReadLine());
        Console.Write("Ingrese práctica 1: ");
        double p1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese práctica 2: ");
        double p2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese práctica 3: ");
        double p3 = double.Parse(Console.ReadLine());

        // Procesamiento
        double minPrac = Math.Min(p1, Math.Min(p2, p3));
        double promPrac = (p1 + p2 + p3 - minPrac) / 2;
        double promFinal = (parcial + final + promPrac) / 3;

        // Salida de cálculos
        Console.WriteLine($"Promedio de prácticas: {promPrac}");
        Console.WriteLine($"Promedio final: {promFinal}");

        // Clasificación
        if (promFinal >= 18) Console.WriteLine("Excelente");
        else if (promFinal >= 14) Console.WriteLine("Bueno");
        else if (promFinal >= 10) Console.WriteLine("Regular");
        else Console.WriteLine("Deficiente");