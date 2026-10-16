Algoritmo Ejercicio50
	
	Definir opcion Como Entero
	Definir np, nc, nv, nd Como Entero
	Definir i, j, codigo, codigoCliente, codigoProducto, cantidad Como Entero
	Definir encontrado Como Logico
	Definir subtotal, descuento, total, totalVentas Como Real
	
	Definir pcodigo, pstock Como Entero
	Definir pnombre, pcategoria Como Caracter
	Definir pprecio Como Real
	
	Definir ccodigo Como Entero
	Definir cnombre, capellido, ctelefono Como Caracter
	
	Definir vcodigo, vcliente, vdetalle Como Entero
	Definir vdescuento, vtotal Como Real
	
	Definir dcodigoVenta, dcodigoProducto, dcantidad Como Entero
	Definir dsubtotal Como Real
	
	Dimension pcodigo[100]
	Dimension pnombre[100]
	Dimension pcategoria[100]
	Dimension pprecio[100]
	Dimension pstock[100]
	
	Dimension ccodigo[100]
	Dimension cnombre[100]
	Dimension capellido[100]
	Dimension ctelefono[100]
	
	Dimension vcodigo[100]
	Dimension vcliente[100]
	Dimension vdetalle[100]
	Dimension vdescuento[100]
	Dimension vtotal[100]
	
	Dimension dcodigoVenta[500]
	Dimension dcodigoProducto[500]
	Dimension dcantidad[500]
	Dimension dsubtotal[500]
	
	np <- 0
	nc <- 0
	nv <- 0
	nd <- 0
	
	Repetir
		
		Escribir ""
		Escribir "======================================"
		Escribir "          SISTEMA DE VENTAS"
		Escribir "======================================"
		Escribir "1. Registrar producto"
		Escribir "2. Registrar cliente"
		Escribir "3. Mostrar productos"
		Escribir "4. Buscar producto"
		Escribir "5. Registrar venta"
		Escribir "6. Mostrar ventas"
		Escribir "7. Reporte de ventas"
		Escribir "8. Salir"
		Escribir "======================================"
		Escribir "Seleccione una opcion:"
		Leer opcion
		
		Segun opcion Hacer
			
			1:
				Escribir ""
				Escribir "===== REGISTRAR PRODUCTO ====="
				
				Escribir "Codigo:"
				Leer codigo
				
				encontrado <- Falso
				
				Para i <- 1 Hasta np
					Si pcodigo[i] = codigo Entonces
						encontrado <- Verdadero
					FinSi
				FinPara
				
				Si encontrado Entonces
					Escribir "El codigo ya existe."
				SiNo
					np <- np + 1
					pcodigo[np] <- codigo
					
					Escribir "Nombre:"
					Leer pnombre[np]
					
					Escribir "Categoria:"
					Leer pcategoria[np]
					
					Escribir "Precio:"
					Leer pprecio[np]
					
					Escribir "Stock:"
					Leer pstock[np]
					
					Escribir "Producto registrado correctamente."
				FinSi
				
				
			2:
				Escribir ""
				Escribir "===== REGISTRAR CLIENTE ====="
				
				Escribir "Codigo:"
				Leer codigo
				
				encontrado <- Falso
				
				Para i <- 1 Hasta nc
					Si ccodigo[i] = codigo Entonces
						encontrado <- Verdadero
					FinSi
				FinPara
				
				Si encontrado Entonces
					Escribir "El codigo ya existe."
				SiNo
					nc <- nc + 1
					ccodigo[nc] <- codigo
					
					Escribir "Nombre:"
					Leer cnombre[nc]
					
					Escribir "Apellido:"
					Leer capellido[nc]
					
					Escribir "Telefono:"
					Leer ctelefono[nc]
					
					Escribir "Cliente registrado correctamente."
				FinSi
				
				
			3:
				Escribir ""
				Escribir "===== PRODUCTOS ====="
				
				Si np = 0 Entonces
					Escribir "No hay productos registrados."
				SiNo
					Para i <- 1 Hasta np
						Escribir "-----------------------------"
						Escribir "Codigo: ", pcodigo[i]
						Escribir "Nombre: ", pnombre[i]
						Escribir "Categoria: ", pcategoria[i]
						Escribir "Precio: ", pprecio[i], " Bs"
						Escribir "Stock: ", pstock[i]
					FinPara
				FinSi
				
				
			4:
				Escribir ""
				Escribir "===== BUSCAR PRODUCTO ====="
				Escribir "Ingrese codigo:"
				Leer codigo
				
				encontrado <- Falso
				
				Para i <- 1 Hasta np
					Si pcodigo[i] = codigo Entonces
						Escribir "Codigo: ", pcodigo[i]
						Escribir "Nombre: ", pnombre[i]
						Escribir "Categoria: ", pcategoria[i]
						Escribir "Precio: ", pprecio[i], " Bs"
						Escribir "Stock: ", pstock[i]
						encontrado <- Verdadero
					FinSi
				FinPara
				
				Si No encontrado Entonces
					Escribir "Producto no encontrado."
				FinSi
				
				
			5:
				Escribir ""
				Escribir "===== REGISTRAR VENTA ====="
				
				Si np = 0 Entonces
					Escribir "No existen productos."
				SiNo
					
					Si nc = 0 Entonces
						Escribir "No existen clientes."
					SiNo
						
						Escribir "Codigo del cliente:"
						Leer codigoCliente
						
						encontrado <- Falso
						
						Para i <- 1 Hasta nc
							Si ccodigo[i] = codigoCliente Entonces
								encontrado <- Verdadero
							FinSi
						FinPara
						
						Si No encontrado Entonces
							Escribir "Cliente no encontrado."
						SiNo
							
							nv <- nv + 1
							vcodigo[nv] <- nv
							vcliente[nv] <- codigoCliente
							subtotal <- 0
							vdetalle[nv] <- 0
							
							Repetir
								Escribir ""
								Escribir "Productos disponibles:"
								
								Para i <- 1 Hasta np
									Escribir pcodigo[i], " - ", pnombre[i], " | Precio: ", pprecio[i], " | Stock: ", pstock[i]
								FinPara
								
								Escribir ""
								Escribir "Codigo del producto:"
								Leer codigoProducto
								
								encontrado <- Falso
								j <- 0
								
								Para i <- 1 Hasta np
									Si pcodigo[i] = codigoProducto Entonces
										encontrado <- Verdadero
										j <- i
									FinSi
								FinPara
								
								Si No encontrado Entonces
									Escribir "Producto no encontrado."
								SiNo
									
									Escribir "Cantidad:"
									Leer cantidad
									
									Si cantidad <= 0 Entonces
										Escribir "Cantidad invalida."
									SiNo
										
										Si cantidad > pstock[j] Entonces
											Escribir "Stock insuficiente."
										SiNo
											
											nd <- nd + 1
											dcodigoVenta[nd] <- nv
											dcodigoProducto[nd] <- codigoProducto
											dcantidad[nd] <- cantidad
											dsubtotal[nd] <- pprecio[j] * cantidad
											
											subtotal <- subtotal + dsubtotal[nd]
											vdetalle[nv] <- vdetalle[nv] + 1
											
											pstock[j] <- pstock[j] - cantidad
											
											Escribir "Producto agregado a la venta."
										FinSi
									FinSi
								FinSi
								
								Escribir "Desea agregar otro producto? (1=Si, 0=No)"
								Leer opcion
								
							Hasta Que opcion = 0
							
							Si vdetalle[nv] = 0 Entonces
								Escribir "La venta no contiene productos."
								nv <- nv - 1
							SiNo
								
								Escribir "Ingrese descuento (%):"
								Leer descuento
								
								Si descuento < 0 Entonces
									descuento <- 0
								FinSi
								
								Si descuento > 100 Entonces
									descuento <- 100
								FinSi
								
								vdescuento[nv] <- descuento
								
								total <- subtotal - (subtotal * descuento / 100)
								vtotal[nv] <- total
								
								Escribir ""
								Escribir "======================================"
								Escribir "         COMPROBANTE DE VENTA"
								Escribir "======================================"
								Escribir "Venta Nro: ", vcodigo[nv]
								Escribir "Cliente: ", codigoCliente
								
								Para i <- 1 Hasta nd
									Si dcodigoVenta[i] = nv Entonces
										Escribir "Producto: ", dcodigoProducto[i]
										Escribir "Cantidad: ", dcantidad[i]
										Escribir "Subtotal: ", dsubtotal[i], " Bs"
										Escribir "-----------------------------"
									FinSi
								FinPara
								
								Escribir "Subtotal: ", subtotal, " Bs"
								Escribir "Descuento: ", descuento, "%"
								Escribir "TOTAL: ", total, " Bs"
								Escribir "======================================"
								Escribir "Venta registrada correctamente."
							FinSi
						FinSi
					FinSi
				FinSi
				
				
			6:
				Escribir ""
				Escribir "===== VENTAS REALIZADAS ====="
				
				Si nv = 0 Entonces
					Escribir "No existen ventas."
				SiNo
					
					Para i <- 1 Hasta nv
						Escribir "-----------------------------"
						Escribir "Venta Nro: ", vcodigo[i]
						Escribir "Cliente: ", vcliente[i]
						Escribir "Productos: ", vdetalle[i]
						Escribir "Descuento: ", vdescuento[i], "%"
						Escribir "Total: ", vtotal[i], " Bs"
					FinPara
				FinSi
				
				
			7:
				Escribir ""
				Escribir "===== REPORTE DE VENTAS ====="
				
				Si nv = 0 Entonces
					Escribir "No existen ventas."
				SiNo
					
					totalVentas <- 0
					
					Para i <- 1 Hasta nv
						totalVentas <- totalVentas + vtotal[i]
					FinPara
					
					Escribir "Cantidad de ventas: ", nv
					Escribir "Total vendido: ", totalVentas, " Bs"
					
					Escribir ""
					Escribir "===== RESUMEN ====="
					
					Para i <- 1 Hasta nv
						Escribir "Venta Nro ", vcodigo[i], " - ", vtotal[i], " Bs"
					FinPara
				FinSi
				
				
			8:
				Escribir ""
				Escribir "Gracias por utilizar el sistema."
				
				
			De Otro Modo:
				Escribir "Opcion invalida."
				
		FinSegun
		
	Hasta Que opcion = 8
	
FinAlgoritmo