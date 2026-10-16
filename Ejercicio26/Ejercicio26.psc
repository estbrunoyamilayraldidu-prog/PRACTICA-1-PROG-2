Algoritmo Ejercicio26
    Definir numero, original, invertido, digito Como Entero
	
    Escribir "Ingrese un número entero:"
    Leer numero
	
    Si numero < 0 Entonces
        Escribir "El número no es capicúa."
    SiNo
        original <- numero
        invertido <- 0
		
        Mientras numero > 0 Hacer
            digito <- numero MOD 10
            invertido <- invertido * 10 + digito
            numero <- Trunc(numero / 10)
        FinMientras
		
        Si original = invertido Entonces
            Escribir "El número es capicúa."
        SiNo
            Escribir "El número no es capicúa."
        FinSi
    FinSi
FinAlgoritmo