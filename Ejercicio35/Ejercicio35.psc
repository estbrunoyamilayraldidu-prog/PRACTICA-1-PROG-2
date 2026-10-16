Algoritmo Ejercicio35
	Definir n, f, i, j, cont Como Entero
	Dimension n[20]
	Dimension f[20]
	
	Para i <- 1 Hasta 20
		Escribir "Ingrese número ", i, ":"
		Leer n[i]
	FinPara
	
	Para i <- 1 Hasta 20
		cont <- 0
		
		Para j <- 1 Hasta 20
			Si n[i] = n[j] Entonces
				cont <- cont + 1
			FinSi
		FinPara
		
		f[i] <- cont
	FinPara
	
	Para i <- 1 Hasta 20
		Escribir n[i], " aparece ", f[i], " veces."
	FinPara
FinAlgoritmo