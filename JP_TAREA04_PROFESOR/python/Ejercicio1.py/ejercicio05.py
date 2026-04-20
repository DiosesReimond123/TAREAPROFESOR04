edad = int(input("Ingrese su edad: "))

if edad >= 18:
    print("Acceso permitido. Bienvenido.")
else:
    faltantes = abs(edad - 18)
    print("Acceso denegado.")
    print(f"Te faltan {faltantes} año(s) para registrarte.")