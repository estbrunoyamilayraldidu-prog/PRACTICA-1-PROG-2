Algoritmo Ejercicio09
    Definir numero1, numero2, numero3, mayor Como Entero
	
    Escribir "Ingrese el primer número:"
    Leer numero1
	
    Escribir "Ingrese el segundo número:"
    Leer numero2
	
    Escribir "Ingrese el tercer número:"
    Leer numero3
	
    mayor <- numero1
	
    Si numero2 > mayor Entonces
        mayor <- numero2
    FinSi
	
    Si numero3 > mayor Entonces
        mayor <- numero3
    FinSi
	
    Escribir ""
    Escribir "===== RESULTADO ====="
    Escribir "El número mayor es: ", mayor
FinAlgoritmo