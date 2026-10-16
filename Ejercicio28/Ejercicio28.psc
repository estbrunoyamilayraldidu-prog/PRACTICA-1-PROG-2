Algoritmo Ejercicio28
    Definir secreto, intento, cantidadIntentos Como Entero
	
    secreto <- Aleatorio(1, 100)
    cantidadIntentos <- 0
	
    Escribir "Adivina el número entre 1 y 100."
	
    Repetir
		
        Escribir "Ingrese su intento:"
        Leer intento
		
        cantidadIntentos <- cantidadIntentos + 1
		
        Si intento < secreto Entonces
            Escribir "El número es mayor."
        SiNo
            Si intento > secreto Entonces
                Escribir "El número es menor."
            SiNo
                Escribir "Correcto."
            FinSi
        FinSi
		
    Hasta Que intento = secreto
	
    Escribir "Cantidad de intentos: ", cantidadIntentos
FinAlgoritmo