Algoritmo Ejercicio39
	Definir a, b, c, i, j Como Entero
	Dimension a[3,3], b[3,3], c[3,3]
	
	Escribir "Matriz A:"
	Para i <- 1 Hasta 3
		Para j <- 1 Hasta 3
			Leer a[i,j]
		FinPara
	FinPara
	
	Escribir "Matriz B:"
	Para i <- 1 Hasta 3
		Para j <- 1 Hasta 3
			Leer b[i,j]
			c[i,j] <- a[i,j] + b[i,j]
		FinPara
	FinPara
	
	Escribir "Resultado:"
	Para i <- 1 Hasta 3
		Para j <- 1 Hasta 3
			Escribir Sin Saltar c[i,j], " "
		FinPara
		Escribir ""
	FinPara
FinAlgoritmo