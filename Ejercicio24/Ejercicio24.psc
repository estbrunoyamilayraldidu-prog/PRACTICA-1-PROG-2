Algoritmo Ejercicio24
    Definir numero, original, invertido, digito Como Entero
	
    Escribir "Ingrese un número entero:"
    Leer numero
	
    original <- numero
    invertido <- 0
	
    Si numero < 0 Entonces
        numero <- numero * (-1)
    FinSi
	
    Mientras numero > 0 Hacer
        digito <- numero MOD 10
        invertido <- invertido * 10 + digito
        numero <- Trunc(numero / 10)
    FinMientras
	
    Si original < 0 Entonces
        invertido <- invertido * (-1)
    FinSi
	
    Escribir "Número invertido: ", invertido
FinAlgoritmo