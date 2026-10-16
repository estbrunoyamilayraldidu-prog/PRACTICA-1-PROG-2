Algoritmo Ejercicio27
    Definir opcion Como Entero
    Definir numero1, numero2, resultado Como Real
	
    Repetir
        Escribir ""
        Escribir "===== MENÚ ====="
        Escribir "1. Sumar"
        Escribir "2. Restar"
        Escribir "3. Multiplicar"
        Escribir "4. Dividir"
        Escribir "5. Salir"
        Escribir "Seleccione una opción:"
        Leer opcion
		
        Si opcion >= 1 Y opcion <= 4 Entonces
			
            Escribir "Ingrese el primer número:"
            Leer numero1
			
            Escribir "Ingrese el segundo número:"
            Leer numero2
			
            Segun opcion Hacer
				
                1:
                    resultado <- numero1 + numero2
                    Escribir "Resultado: ", resultado
					
                2:
                    resultado <- numero1 - numero2
                    Escribir "Resultado: ", resultado
					
                3:
                    resultado <- numero1 * numero2
                    Escribir "Resultado: ", resultado
					
                4:
                    Si numero2 <> 0 Entonces
                        resultado <- numero1 / numero2
                        Escribir "Resultado: ", resultado
                    SiNo
                        Escribir "No se puede dividir entre cero."
                    FinSi
					
            FinSegun
			
        SiNo
            Si opcion <> 5 Entonces
                Escribir "Opción no válida."
            FinSi
        FinSi
		
    Hasta Que opcion = 5
	
    Escribir "Programa finalizado."
FinAlgoritmo