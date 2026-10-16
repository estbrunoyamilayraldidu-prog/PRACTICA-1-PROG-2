Algoritmo Ejercicio32
	Definir n, buscar, i, pos Como Entero
	Dimension n[10]
	pos <- 0
	
	Para i <- 1 Hasta 10
		Escribir "Ingrese número ", i, ":"
		Leer n[i]
	FinPara
	
	Escribir "Número a buscar:"
	Leer buscar
	
	Para i <- 1 Hasta 10
		Si n[i] = buscar Entonces
			pos <- i
			Escribir "Encontrado en la posición: ", i
		FinSi
	FinPara
	
	Si pos = 0 Entonces
		Escribir "Número no encontrado."
	FinSi
FinAlgoritmo