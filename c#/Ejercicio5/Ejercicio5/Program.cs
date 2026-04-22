        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Acceso permitido. Bienvenido.");
        }
        else
        {
            int faltan = Math.Abs(edad - 18);
            Console.WriteLine("Acceso denegado.");
            Console.WriteLine($"Te faltan {faltan} año(s) para registrarte.");
        }