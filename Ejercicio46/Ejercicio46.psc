Algoritmo Ejercicio46
	Definir nombre Como Caracter
	Definir edad,nota Como Entero
	
	Escribir "Nombre:"
	Leer nombre
	
	Escribir "Edad:"
	Leer edad
	
	Escribir "Nota:"
	Leer nota
	
	Escribir "===== ESTUDIANTE ====="
	Escribir "Nombre: ",nombre
	Escribir "Edad: ",edad
	Escribir "Nota: ",nota
	
	Si nota >= 51 Entonces
		Escribir "Estado: APROBADO"
	SiNo
		Escribir "Estado: REPROBADO"
	FinSi
FinAlgoritmo