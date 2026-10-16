Algoritmo Ejercicio03
    Definir numero1, numero2 Como Real
	
    Escribir "Ingrese el primer número:"
    Leer numero1
	
    Escribir "Ingrese el segundo número:"
    Leer numero2
	
    Escribir ""
    Escribir "===== RESULTADOS ====="
    Escribir "Suma: ", numero1 + numero2
    Escribir "Resta: ", numero1 - numero2
    Escribir "Multiplicación: ", numero1 * numero2
	
    Si numero2 <> 0 Entonces
        Escribir "División: ", numero1 / numero2
    SiNo
        Escribir "División: No se puede dividir entre cero."
    FinSi
FinAlgoritmo