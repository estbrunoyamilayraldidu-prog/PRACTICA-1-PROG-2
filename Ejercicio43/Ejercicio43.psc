Algoritmo Ejercicio43
	Definir num1, num2, resultado Como Real
	Definir operacion Como Caracter
	
	Escribir "Ingrese el primer número:"
	Leer num1
	
	Escribir "Ingrese el segundo número:"
	Leer num2
	
	Escribir "Ingrese la operación (+, -, *, /):"
	Leer operacion
	
	Si operacion = "+" Entonces
		resultado <- num1 + num2
		Escribir "Resultado: ", resultado
	FinSi
	
	Si operacion = "-" Entonces
		resultado <- num1 - num2
		Escribir "Resultado: ", resultado
	FinSi
	
	Si operacion = "*" Entonces
		resultado <- num1 * num2
		Escribir "Resultado: ", resultado
	FinSi
	
	Si operacion = "/" Entonces
		Si num2 <> 0 Entonces
			resultado <- num1 / num2
			Escribir "Resultado: ", resultado
		SiNo
			Escribir "No se puede dividir entre cero."
		FinSi
	FinSi
FinAlgoritmo