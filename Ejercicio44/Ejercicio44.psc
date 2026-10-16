Algoritmo Ejercicio44
	Definir n,i,div Como Entero
	Definir primo Como Logico
	
	Para n <- 2 Hasta 1000
		primo <- Verdadero
		div <- 2
		
		Mientras div*div <= n Y primo Hacer
			Si n MOD div = 0 Entonces
				primo <- Falso
			FinSi
			div <- div+1
		FinMientras
		
		Si primo Entonces
			Escribir n
		FinSi
	FinPara
FinAlgoritmo