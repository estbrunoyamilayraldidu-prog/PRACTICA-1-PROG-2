Algoritmo Ejercicio30
    Definir contraseñaCorrecta, contraseña Como Cadena
    Definir intentos Como Entero
    Definir acceso Como Logico
	
    contraseñaCorrecta <- "123456"
    intentos <- 0
    acceso <- Falso
	
    Mientras intentos < 3 Y acceso = Falso Hacer
		
        Escribir "Ingrese la contraseña:"
        Leer contraseña
		
        intentos <- intentos + 1
		
        Si contraseña = contraseñaCorrecta Entonces
            acceso <- Verdadero
            Escribir "Acceso permitido."
        SiNo
            Escribir "Contraseña incorrecta."
        FinSi
		
    FinMientras
	
    Si acceso = Falso Entonces
        Escribir "Acceso bloqueado después de tres intentos."
    FinSi
FinAlgoritmo