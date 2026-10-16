Algoritmo Ejercicio25
    Definir numero, cantidad Como Entero
	
    Escribir "Ingrese un número entero:"
    Leer numero
	
    Si numero < 0 Entonces
        numero <- numero * (-1)
    FinSi
	
    cantidad <- 0
	
    Si numero = 0 Entonces
        cantidad <- 1
    SiNo
        Mientras numero > 0 Hacer
            numero <- Trunc(numero / 10)
            cantidad <- cantidad + 1
        FinMientras
    FinSi
	
    Escribir "El número tiene ", cantidad, " dígitos."
FinAlgoritmo