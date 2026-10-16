Algoritmo Ejercicio07
    Definir numero Como Entero
	
    Escribir "Ingrese un número entero:"
    Leer numero
	
    Escribir ""
    Escribir "===== RESULTADO ====="
	
    Si numero = 0 Entonces
        Escribir "El número es CERO."
    SiNo
        Si numero > 0 Entonces
            Escribir "El número es POSITIVO."
        SiNo
            Escribir "El número es NEGATIVO."
        FinSi
		
        Si numero MOD 2 = 0 Entonces
            Escribir "El número es PAR."
        SiNo
            Escribir "El número es IMPAR."
        FinSi
    FinSi
FinAlgoritmo