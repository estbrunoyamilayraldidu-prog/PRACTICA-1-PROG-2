Algoritmo Ejercicio36
	Definir n, i, suma, mayor, menor, aprobados, reprobados Como Entero
	Definir promedio Como Real
	Dimension n[10]
	
	suma <- 0
	aprobados <- 0
	reprobados <- 0
	
	Para i <- 1 Hasta 10
		Escribir "Nota del estudiante ", i, ":"
		Leer n[i]
		suma <- suma + n[i]
		
		Si n[i] >= 51 Entonces
			aprobados <- aprobados + 1
		SiNo
			reprobados <- reprobados + 1
		FinSi
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
	
	Escribir "Promedio: ", promedio
	Escribir "Mayor: ", mayor
	Escribir "Menor: ", menor
	Escribir "Aprobados: ", aprobados
	Escribir "Reprobados: ", reprobados
FinAlgoritmo