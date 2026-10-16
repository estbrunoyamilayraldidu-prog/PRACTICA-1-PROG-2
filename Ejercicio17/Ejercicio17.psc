Algoritmo Ejercicio17
    Definir i, cantidad Como Entero
	
    cantidad <- 0
	
    Para i <- 1 Hasta 100 Hacer
        Si i MOD 2 = 0 Entonces
            Escribir i
            cantidad <- cantidad + 1
        FinSi
    FinPara
	
    Escribir ""
    Escribir "Cantidad de números pares: ", cantidad
FinAlgoritmo