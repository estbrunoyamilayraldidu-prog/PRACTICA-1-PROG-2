Algoritmo Ejercicio42
	Definir frase, limpia, invertida Como Caracter
	Definir i Como Entero
	
	Escribir "Ingrese una frase:"
	Leer frase
	
	limpia <- ""
	
	Para i <- 1 Hasta Longitud(frase)
		Si Subcadena(Minusculas(frase),i,i) <> " " Entonces
			limpia <- Concatenar(limpia,Subcadena(Minusculas(frase),i,i))
		FinSi
	FinPara
	
	invertida <- ""
	
	Para i <- Longitud(limpia) Hasta 1 Con Paso -1
		invertida <- Concatenar(invertida,Subcadena(limpia,i,i))
	FinPara
	
	Si limpia = invertida Entonces
		Escribir "Es un palíndromo."
	SiNo
		Escribir "No es un palíndromo."
	FinSi
FinAlgoritmo