Algoritmo Ejercicio49
	Definir cod,n,edad,op,i,codigo Como Entero
	Definir nombres,apellidos,carreras Como Caracter
	Definir notas,suma Como Real
	Definir encontrado Como Logico
	
	Dimension cod[100],edad[100],nombres[100],apellidos[100],carreras[100],notas[100]
	n <- 0
	
	Repetir
		Escribir ""
		Escribir "===== SISTEMA DE ESTUDIANTES ====="
		Escribir "1. Registrar"
		Escribir "2. Listar"
		Escribir "3. Buscar código"
		Escribir "4. Buscar nombre"
		Escribir "5. Aprobados"
		Escribir "6. Reprobados"
		Escribir "7. Promedio"
		Escribir "8. Salir"
		Leer op
		
		Segun op Hacer
			1:
				n <- n+1
				
				Escribir "Código:"
				Leer cod[n]
				Escribir "Nombre:"
				Leer nombres[n]
				Escribir "Apellido:"
				Leer apellidos[n]
				Escribir "Edad:"
				Leer edad[n]
				Escribir "Carrera:"
				Leer carreras[n]
				Escribir "Nota:"
				Leer notas[n]
				
			2:
				Para i <- 1 Hasta n
					Escribir cod[i]," | ",nombres[i]," ",apellidos[i]," | ",notas[i]
				FinPara
				
			3:
				Escribir "Código:"
				Leer codigo
				encontrado <- Falso
				
				Para i <- 1 Hasta n
					Si cod[i] = codigo Entonces
						Escribir nombres[i]," ",apellidos[i]," - ",carreras[i]," - Nota: ",notas[i]
						encontrado <- Verdadero
					FinSi
				FinPara
				
				Si No encontrado Entonces
					Escribir "Estudiante no encontrado."
				FinSi
				
			4:
				Escribir "Nombre:"
				Leer codigo
				encontrado <- Falso
				
				Para i <- 1 Hasta n
					Si nombres[i] = codigo Entonces
						Escribir cod[i]," | ",nombres[i]," ",apellidos[i]," | Nota: ",notas[i]
						encontrado <- Verdadero
					FinSi
				FinPara
				
				Si No encontrado Entonces
					Escribir "Estudiante no encontrado."
				FinSi
				
			5:
				Escribir "===== APROBADOS ====="
				Para i <- 1 Hasta n
					Si notas[i] >= 51 Entonces
						Escribir nombres[i]," ",apellidos[i]," - ",notas[i]
					FinSi
				FinPara
				
			6:
				Escribir "===== REPROBADOS ====="
				Para i <- 1 Hasta n
					Si notas[i] < 51 Entonces
						Escribir nombres[i]," ",apellidos[i]," - ",notas[i]
					FinSi
				FinPara
				
			7:
				Si n > 0 Entonces
					suma <- 0
					Para i <- 1 Hasta n
						suma <- suma+notas[i]
					FinPara
					Escribir "Promedio general: ",suma/n
				SiNo
					Escribir "No hay estudiantes."
				FinSi
				
			8:
				Escribir "Programa finalizado."
				
			De Otro Modo:
				Escribir "Opción inválida."
		FinSegun
	Hasta Que op = 8
FinAlgoritmo