Algoritmo Ejercicio47
	Definir saldo,monto Como Real
	Definir op Como Entero
	
	saldo <- 0
	
	Repetir
		Escribir ""
		Escribir "1. Depositar"
		Escribir "2. Retirar"
		Escribir "3. Consultar saldo"
		Escribir "4. Salir"
		Leer op
		
		Segun op Hacer
			1:
				Escribir "Monto a depositar:"
				Leer monto
				
				Si monto > 0 Entonces
					saldo <- saldo+monto
					Escribir "Depósito realizado."
				SiNo
					Escribir "Monto inválido."
				FinSi
				
			2:
				Escribir "Monto a retirar:"
				Leer monto
				
				Si monto > 0 Y monto <= saldo Entonces
					saldo <- saldo-monto
					Escribir "Retiro realizado."
				SiNo
					Escribir "Saldo insuficiente o monto inválido."
				FinSi
				
			3:
				Escribir "Saldo: ",saldo
				
			4:
				Escribir "Cuenta cerrada."
				
			De Otro Modo:
				Escribir "Opción inválida."
		FinSegun
	Hasta Que op = 4
FinAlgoritmo