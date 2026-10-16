Algoritmo Ejercicio21
    Definir base, exponente, i Como Entero
    Definir resultado Como Entero
	
    Escribir "Ingrese la base:"
    Leer base
	
    Escribir "Ingrese el exponente positivo:"
    Leer exponente
	
    resultado <- 1
	
    Para i <- 1 Hasta exponente Hacer
        resultado <- resultado * base
    FinPara
	
    Escribir "Resultado: ", resultado
FinAlgoritmo