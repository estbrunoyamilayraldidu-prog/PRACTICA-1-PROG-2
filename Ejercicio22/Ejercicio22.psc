Algoritmo Ejercicio22
    Definir numero, i Como Entero
    Definir esPrimo Como Logico
	
    Escribir "Ingrese un número entero positivo:"
    Leer numero
	
    esPrimo <- Verdadero
	
    Si numero < 2 Entonces
        esPrimo <- Falso
    SiNo
        Para i <- 2 Hasta numero - 1 Hacer
            Si numero MOD i = 0 Entonces
                esPrimo <- Falso
            FinSi
        FinPara
    FinSi
	
    Si esPrimo Entonces
        Escribir "El número es primo."
    SiNo
        Escribir "El número no es primo."
    FinSi
FinAlgoritmo