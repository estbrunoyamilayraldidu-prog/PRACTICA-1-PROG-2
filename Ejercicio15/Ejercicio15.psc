Algoritmo Ejercicio15
    Definir edad Como Entero
	
    Escribir "Ingrese la edad:"
    Leer edad
	
    Si edad < 0 Entonces
        Escribir "Error: la edad no puede ser negativa."
    SiNo
        Si edad <= 5 Entonces
            Escribir "Primera infancia."
        SiNo
            Si edad <= 11 Entonces
                Escribir "Infancia."
            SiNo
                Si edad <= 17 Entonces
                    Escribir "Adolescencia."
                SiNo
                    Si edad <= 59 Entonces
                        Escribir "Adulto."
                    SiNo
                        Escribir "Adulto mayor."
                    FinSi
                FinSi
            FinSi
        FinSi
    FinSi
FinAlgoritmo