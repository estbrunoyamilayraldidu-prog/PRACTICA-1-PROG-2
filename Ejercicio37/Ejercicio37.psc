Algoritmo Ejercicio37
	Definir m, i, j, suma, d1, d2 Como Entero
	Dimension m[3,3]
	
	suma <- 0
	d1 <- 0
	d2 <- 0
	
	Para i <- 1 Hasta 3
		Para j <- 1 Hasta 3
			Escribir "M[",i,",",j,"]:"
			Leer m[i,j]
			suma <- suma + m[i,j]
			
			Si i = j Entonces
				d1 <- d1 + m[i,j]
			FinSi
			
			Si i + j = 4 Entonces
				d2 <- d2 + m[i,j]
			FinSi
		FinPara
	FinPara
	
	Escribir "Suma total: ", suma
	Escribir "Diagonal principal: ", d1
	Escribir "Diagonal secundaria: ", d2
FinAlgoritmo