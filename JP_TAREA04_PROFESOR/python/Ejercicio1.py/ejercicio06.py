promedio = float(input("Ingrese el promedio (0-20): "))

if promedio < 0 or promedio > 20:
    print("Valor inválido")
else:
    if promedio <= 5:
        print("Deficiente")
    else:
        if promedio <= 10:
            print("Regular")
        else:
            if promedio <= 14:
                print("Bueno")
            else:
                print("Excelente")