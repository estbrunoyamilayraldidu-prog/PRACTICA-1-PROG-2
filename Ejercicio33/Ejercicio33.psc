Algoritmo Ejercicio33
	Definir n, i, j, aux Como Entero
	Dimension n[10]
	
	Para i <- 1 Hasta 10
		Escribir "Ingrese número ", i, ":"
		Leer n[i]
	FinPara
	
	Para i <- 1 Hasta 9
		Para j <- i + 1 Hasta 10
			Si n[i] > n[j] Entonces
				aux <- n[i]
				n[i] <- n[j]
				n[j] <- aux
			FinSi
		FinPara
	FinPara
	
	Escribir "Ordenados:"
	Para i <- 1 Hasta 10
		Escribir n[i]
	FinPara
FinAlgoritmo