Algoritmo Ejercicio29
    Definir n, i Como Entero
    Definir numero, suma, promedio, mayor, menor Como Real
	
    Escribir "¿Cuántos números desea ingresar?"
    Leer n
	
    Si n <= 0 Entonces
        Escribir "La cantidad debe ser mayor que cero."
    SiNo
		
        suma <- 0
		
        Para i <- 1 Hasta n Hacer
			
            Escribir "Ingrese el número ", i, ":"
            Leer numero
			
            suma <- suma + numero
			
            Si i = 1 Entonces
                mayor <- numero
                menor <- numero
            SiNo
				
                Si numero > mayor Entonces
                    mayor <- numero
                FinSi
				
                Si numero < menor Entonces
                    menor <- numero
                FinSi
				
            FinSi
			
        FinPara
		
        promedio <- suma / n
		
        Escribir ""
        Escribir "===== RESULTADOS ====="
        Escribir "Suma: ", suma
        Escribir "Promedio: ", promedio
        Escribir "Mayor: ", mayor
        Escribir "Menor: ", menor
		
    FinSi
FinAlgoritmo