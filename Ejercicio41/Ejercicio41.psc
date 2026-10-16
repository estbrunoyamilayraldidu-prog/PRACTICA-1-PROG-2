Algoritmo Ejercicio41
	Definir f, i, caracteres, palabras, vocales, consonantes, espacios Como Entero
	Definir letra Como Caracter
	
	Escribir "Ingrese una frase:"
	Leer f
	
	caracteres <- Longitud(f)
	palabras <- 1
	vocales <- 0
	consonantes <- 0
	espacios <- 0
	
	Para i <- 1 Hasta caracteres
		letra <- Minusculas(Subcadena(f,i,i))
		
		Si letra = " " Entonces
			espacios <- espacios + 1
			palabras <- palabras + 1
		SiNo
			Si letra = "a" O letra = "e" O letra = "i" O letra = "o" O letra = "u" Entonces
				vocales <- vocales + 1
			SiNo
				Si (letra >= "a" Y letra <= "z") Entonces
					consonantes <- consonantes + 1
				FinSi
			FinSi
		FinSi
	FinPara
	
	Escribir "Caracteres: ", caracteres
	Escribir "Palabras: ", palabras
	Escribir "Vocales: ", vocales
	Escribir "Consonantes: ", consonantes
	Escribir "Espacios: ", espacios
FinAlgoritmo