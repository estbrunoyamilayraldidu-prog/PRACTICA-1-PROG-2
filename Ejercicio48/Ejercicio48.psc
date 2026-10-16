Algoritmo Ejercicio48
	Definir nombres Como Caracter
	Definir precios Como Real
	Definir stock Como Entero
	Definir n,i,op,cod Como Entero
	Definir total Como Real
	
	Dimension nombres[100]
	Dimension precios[100]
	Dimension stock[100]
	
	n <- 0
	
	Repetir
		Escribir ""
		Escribir "===== INVENTARIO ====="
		Escribir "1. Registrar"
		Escribir "2. Mostrar"
		Escribir "3. Buscar"
		Escribir "4. Modificar stock"
		Escribir "5. Total inventario"
		Escribir "6. Salir"
		Leer op
		
		Segun op Hacer
			1:
				n <- n+1
				
				Escribir "Nombre:"
				Leer nombres[n]
				
				Escribir "Precio:"
				Leer precios[n]
				
				Escribir "Stock:"
				Leer stock[n]
				
			2:
				Para i <- 1 Hasta n
					Escribir i," - ",nombres[i]," | ",precios[i]," Bs | Stock: ",stock[i]
				FinPara
				
			3:
				Escribir "Código:"
				Leer cod
				
				Si cod >= 1 Y cod <= n Entonces
					Escribir nombres[cod]," | ",precios[cod]," Bs | Stock: ",stock[cod]
				SiNo
					Escribir "Producto no encontrado."
				FinSi
				
			4:
				Escribir "Código:"
				Leer cod
				
				Si cod >= 1 Y cod <= n Entonces
					Escribir "Nuevo stock:"
					Leer stock[cod]
				SiNo
					Escribir "Producto no encontrado."
				FinSi
				
			5:
				total <- 0
				
				Para i <- 1 Hasta n
					total <- total + precios[i]*stock[i]
				FinPara
				
				Escribir "Valor total: ",total," Bs"
				
			6:
				Escribir "Programa finalizado."
				
			De Otro Modo:
				Escribir "Opción inválida."
		FinSegun
	Hasta Que op = 6
FinAlgoritmo