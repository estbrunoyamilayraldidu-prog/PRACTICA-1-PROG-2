Algoritmo Ejercicio45
	Definir nota Como Real
	
	Repetir
		Escribir "Ingrese nota entre 0 y 100:"
		Leer nota
		
		Si nota < 0 O nota > 100 Entonces
			Escribir "Nota inválida."
		FinSi
	Hasta Que nota >= 0 Y nota <= 100
	
	Si nota >= 51 Entonces
		Escribir "Aprobado."
	SiNo
		Escribir "Reprobado."
	FinSi
FinAlgoritmo