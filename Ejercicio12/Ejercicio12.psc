Algoritmo Ejercicio12
    Definir precio, porcentaje, descuento, precioFinal Como Real
	
    Escribir "Ingrese el importe de la compra:"
    Leer precio
	
    Si precio < 100 Entonces
        porcentaje <- 0
    SiNo
        Si precio < 500 Entonces
            porcentaje <- 0.05
        SiNo
            Si precio < 1000 Entonces
                porcentaje <- 0.10
            SiNo
                porcentaje <- 0.15
            FinSi
        FinSi
    FinSi
	
    descuento <- precio * porcentaje
    precioFinal <- precio - descuento
	
    Escribir ""
    Escribir "===== COMPRA ====="
    Escribir "Precio original: ", precio, " Bs"
    Escribir "Descuento: ", descuento, " Bs"
    Escribir "Precio final: ", precioFinal, " Bs"
FinAlgoritmo