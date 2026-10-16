Algoritmo Ejercicio38
	Definir m, t, i, j Como Entero
	Dimension m[3,3], t[3,3]
	
	Para i <- 1 Hasta 3
		Para j <- 1 Hasta 3
			Escribir "M[",i,",",j,"]:"
			Leer m[i,j]
			t[j,i] <- m[i,j]
		FinPara
	FinPara
	
	Escribir "Matriz transpuesta:"
	
	Para i <- 1 Hasta 3
		Para j <- 1 Hasta 3
			Escribir Sin Saltar t[i,j], " "
		FinPara
		Escribir ""
	FinPara
FinAlgoritmo