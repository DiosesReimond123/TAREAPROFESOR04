    string cat = Console.ReadLine().ToUpper();
    double horas = double.Parse(Console.ReadLine());
    int anios = int.Parse(Console.ReadLine());
    double tarifa = 0;

    if (cat == "A") tarifa = 33.50; // categoría A
    else if (cat == "B") tarifa = 29.80; // categoría B
    else if (cat == "C") tarifa = 25.70; // categoría C
    else
    {
        Console.WriteLine("Categoría invàlida");
        return;
    }

    double bono = 0;

    if (anios <= 3) bono = 0.00;
    else if (anios >= 4 && anios <= 10) bono = 0.10;
    else if (anios >= 11 && anios <= 17) bono = 0.20;
    else bono = 0.30;

    double sueldoFinal = tarifa * horas * (1 + bono);
    Console.WriteLine($"Sueldo: S/. {sueldoFinal:F2}");
