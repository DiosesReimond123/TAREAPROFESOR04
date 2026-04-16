monto = float(input("ingrese el monto"))
descuento = 0

if monto > 100:
    descuento = monto * 0.10

total = monto - descuento

print(f"descuento aplicado: s/. {round(descuento, 2)}")
print(f"total a pagar: s/. {round(total, 2)}")
