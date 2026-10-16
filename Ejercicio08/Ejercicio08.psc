Algoritmo Ejercicio08
    Definir numero1, numero2 Como Entero
	
    Escribir "Ingrese el primer número:"
    Leer numero1
	
    Escribir "Ingrese el segundo número:"
    Leer numero2
	
    Escribir ""
    Escribir "===== RESULTADO ====="
	
    Si numero1 > numero2 Entonces
        Escribir "El número mayor es: ", numero1
    SiNo
        Si numero2 > numero1 Entonces
            Escribir "El número mayor es: ", numero2
        SiNo
            Escribir "Ambos números son iguales."
        FinSi
    FinSi
FinAlgoritmo