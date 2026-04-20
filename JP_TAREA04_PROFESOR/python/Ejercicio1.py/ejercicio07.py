parcial = float(input("Ingrese examen parcial: "))
final = float(input("Ingrese examen final: "))
p1 = float(input("Ingrese práctica 1: "))
p2 = float(input("Ingrese práctica 2: "))
p3 = float(input("Ingrese práctica 3: "))

prom_prac = (p1 + p2 + p3 - min(p1, p2, p3)) / 2

prom_final = (parcial + final + prom_prac) / 3

print(f"Promedio de prácticas: {round(prom_prac)}")
print(f"Promedio final: {round(prom_final)}")

if prom_final >= 18:
    print("Excelente")
else:
    if prom_final >= 14:
        print("Bueno")
    else:
        if prom_final >= 10:
            print("Regular")
        else:
            print("Deficiente")