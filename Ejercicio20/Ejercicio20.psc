Algoritmo Ejercicio20
    Definir n, i Como Entero
    Definir factorial Como Entero
	
    Escribir "Ingrese un número entero positivo:"
    Leer n
	
    factorial <- 1
	
    Para i <- 1 Hasta n Hacer
        factorial <- factorial * i
    FinPara
	
    Escribir n, "! = ", factorial
FinAlgoritmo