Algoritmo Ejercicio23
    Definir n, i Como Entero
    Definir anterior, actual, siguiente Como Entero
	
    Escribir "Ingrese la cantidad de términos:"
    Leer n
	
    anterior <- 0
    actual <- 1
	
    Escribir ""
    Escribir "===== FIBONACCI ====="
	
    Para i <- 1 Hasta n Hacer
        Escribir Sin Saltar anterior
		
        Si i < n Entonces
            Escribir Sin Saltar ", "
        FinSi
		
        siguiente <- anterior + actual
        anterior <- actual
        actual <- siguiente
    FinPara
	
    Escribir ""
FinAlgoritmo