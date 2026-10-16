Algoritmo Ejercicio34
	Definir n, d, i, j, cant Como Entero
	Definir repetido Como Logico
	Dimension n[10]
	Dimension d[10]
	
	cant <- 0
	
	Para i <- 1 Hasta 10
		Escribir "Ingrese número ", i, ":"
		Leer n[i]
	FinPara
	
	Para i <- 1 Hasta 10
		repetido <- Falso
		
		Para j <- 1 Hasta cant
			Si n[i] = d[j] Entonces
				repetido <- Verdadero
			FinSi
		FinPara
		
		Si No repetido Entonces
			cant <- cant + 1
			d[cant] <- n[i]
		FinSi
	FinPara
	
	Escribir "Valores distintos:"
	Para i <- 1 Hasta cant
		Escribir d[i]
	FinPara
FinAlgoritmo