Algoritmo Ejercicio31
	Definir n, i, suma, mayor, menor Como Entero
	Definir promedio Como Real
	Dimension n[10]
	
	suma <- 0
	
	Para i <- 1 Hasta 10
		Escribir "Ingrese número ", i, ":"
		Leer n[i]
		suma <- suma + n[i]
	FinPara
	
	mayor <- n[1]
	menor <- n[1]
	
	Para i <- 2 Hasta 10
		Si n[i] > mayor Entonces
			mayor <- n[i]
		FinSi
		Si n[i] < menor Entonces
			menor <- n[i]
		FinSi
	FinPara
	
	promedio <- suma / 10
	
	Escribir "Suma: ", suma
	Escribir "Promedio: ", promedio
	Escribir "Mayor: ", mayor
	Escribir "Menor: ", menor
FinAlgoritmo