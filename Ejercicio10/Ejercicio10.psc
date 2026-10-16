Algoritmo Ejercicio10
    Definir numero1, numero2, resultado Como Real
    Definir operacion Como Caracter
	
    Escribir "Ingrese el primer número:"
    Leer numero1
	
    Escribir "Ingrese el segundo número:"
    Leer numero2
	
    Escribir "Ingrese la operación (+, -, *, /):"
    Leer operacion
	
    Escribir ""
    Escribir "===== RESULTADO ====="
	
    Segun operacion Hacer
        "+":
            resultado <- numero1 + numero2
            Escribir "Resultado: ", resultado
			
        "-":
            resultado <- numero1 - numero2
            Escribir "Resultado: ", resultado
			
        "*":
            resultado <- numero1 * numero2
            Escribir "Resultado: ", resultado
			
        "/":
            Si numero2 <> 0 Entonces
                resultado <- numero1 / numero2
                Escribir "Resultado: ", resultado
            SiNo
                Escribir "Error: no se puede dividir entre cero."
            FinSi
			
        De Otro Modo:
            Escribir "Operación no válida."
    FinSegun
FinAlgoritmo