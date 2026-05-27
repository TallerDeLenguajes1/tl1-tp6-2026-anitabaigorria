// PARA EJERCICIO 5
using System;
using System.Text.RegularExpressions; 

string opcionPrincipal;
string ingreso1, ingreso2;
double num1, num2;

do
{
    Console.Clear();
    Console.WriteLine("╔══════════════════════════════════════════╗");
    Console.WriteLine("║          TRABAJO PRÁCTICO N° 6           ║");
    Console.WriteLine("╚══════════════════════════════════════════╝");
    Console.WriteLine("1. Punto 0 y Problema 1 (Invertir numero)");
    Console.WriteLine("2. Problema 2 y Ejercicio 3 (Calculadora)");
    Console.WriteLine("3. Ejercicio 4 (Manejo de strings)");
    Console.WriteLine("4. Ejercicio 5 (Expresiones regulares)");
    Console.WriteLine("0. SALIR DEL PROGRAMA");
    Console.WriteLine("--------------------------------------------");
    Console.Write("Seleccione el ejercicio a probar: ");
    
    opcionPrincipal = Console.ReadLine();
    Console.Clear();

    switch (opcionPrincipal)
    {
        case "1":
        {
            Console.WriteLine(">>> PUNTO 0: HELLO WORLD <<<\n");
            Console.WriteLine("Hello, World!"); 
            int a; 
            int b; 
            a = 10; 
            b = a; 
            Console.WriteLine("valor de a:" + a); 
            Console.WriteLine("valor de b:" + b);

            Console.WriteLine("\n>>> PROBLEMA 1: INVERTIR NÚMERO <<<\n");
            string textoBuscado;
            int numero;

            do
            {
                Console.Write("Ingrese un numero mayor a 0: ");
                textoBuscado = Console.ReadLine(); // Movido adentro del bucle

                if (int.TryParse(textoBuscado, out numero))
                {
                    if (numero > 0)
                    {
                        Console.Write("Numero invertido: ");
                        for (int h = textoBuscado.Length - 1; h >= 0; h--)
                        {
                            Console.Write($"{textoBuscado[h]}");            
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es menor a 0. Intente nuevamente");    
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un numero. Intente nuevamente");
                }
            } while (numero <= 0);

            break;
        }

        case "2":
        {
            Console.WriteLine(">>> PROBLEMA 2 Y EJ. 3: CALCULADORA COMPLETA <<<\n");
            string eleccion;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("-------- CALCULADORA --------");
                Console.WriteLine("1 = Suma");
                Console.WriteLine("2 = Resta");
                Console.WriteLine("3 = Multiplicación");
                Console.WriteLine("4 = División");
                Console.WriteLine("5 = Valor Absoluto");
                Console.WriteLine("6 = Cuadrado");
                Console.WriteLine("7 = Raíz Cuadrada");
                Console.WriteLine("8 = Seno");
                Console.WriteLine("9 = Coseno");
                Console.WriteLine("10 = Parte Entera");
                Console.WriteLine("11 = EJERCICIO 3: Maximo y minimo");
                Console.WriteLine("0 = VOLVER AL MENU PRINCIPAL");
                Console.WriteLine("------------------------------");
                Console.Write("Ingrese: ");
                
                eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "1":
                        Console.Write("Ingrese el primer numero a sumar (_ + ): ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            Console.Write("Ingrese el primer numero a sumar (_ + ): ");
                            ingreso1 = Console.ReadLine();
                        }

                        Console.Write($"Ingrese el segundo numero a sumar ({num1} + _): ");
                        ingreso2 = Console.ReadLine();
                        while (double.TryParse(ingreso2, out num2) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            Console.Write($"Ingrese el segundo numero a sumar ({num1} + _): ");
                            ingreso2 = Console.ReadLine();
                        }
                        Console.WriteLine($"\nResultado: {num1 + num2}");
                        break;
                    
                    case "2":
                        Console.Write("Ingrese el primer numero a restar (_ - ): ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }
                        Console.Write($"Ingrese el segundo numero a restar ({num1} - _): ");
                        ingreso2 = Console.ReadLine();
                        while (double.TryParse(ingreso2, out num2) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso2 = Console.ReadLine();
                        }
                        Console.WriteLine($"\nResultado: {num1 - num2}");
                        break;        
                    
                    case "3":
                        Console.Write("Ingrese el primer numero a multiplicar (_ * ): ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }
                        Console.Write($"Ingrese el segundo numero a multiplicar ({num1} * _): ");
                        ingreso2 = Console.ReadLine();
                        while (double.TryParse(ingreso2, out num2) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso2 = Console.ReadLine();
                        }
                        Console.WriteLine($"\nResultado: {num1 * num2}");
                        break;        
                    
                    case "4":
                        Console.Write("Ingrese el primer numero a dividir (_ / ): ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }
                        Console.WriteLine($"Ingrese el segundo numero a dividir ({num1} / _) ");
                        Console.WriteLine("IMPORTANTE: EL NUMERO NO PUEDE SER CERO");
                        ingreso2 = Console.ReadLine();
                        while (double.TryParse(ingreso2, out num2) == false || num2 == 0) // Corregido a == 0
                        {
                            Console.WriteLine("Error: Ingrese un numero valido y distinto de 0.");
                            ingreso2 = Console.ReadLine();
                        }
                        Console.WriteLine($"\nResultado: {num1 / num2}");
                        break;   
                    
                    case "5":
                        Console.Write("Ingrese un numero: ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }
                        Console.WriteLine($"|{num1}| = {Math.Abs(num1)}");
                        break;
                    
                    case "6":
                        Console.Write("Ingrese un numero: ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }
                        Console.WriteLine($"El cuadrado de {num1} es: {Math.Pow(num1, 2)}");
                        break;
                    
                    case "7":
                        Console.Write("Ingrese un numero: ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false || num1 < 0) 
                        {
                            Console.WriteLine("Error: El numero debe ser mayor o igual a 0.");
                            ingreso1 = Console.ReadLine();
                        }
                        Console.WriteLine($"La raiz cuadrada de {num1} es: {Math.Sqrt(num1)}");
                        break;
                    
                    case "8":
                        Console.Write("Ingrese un numero: ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }
                        Console.WriteLine($"sen({num1}) = {Math.Sin(num1)}");
                        break;
                    
                    case "9":
                        Console.Write("Ingrese un numero: ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }
                        Console.WriteLine($"cos({num1}) = {Math.Cos(num1)}");
                        break;
                    
                    case "10":
                        Console.Write("Ingrese un numero decimal: ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }
                        int Enteronum1 = (int)num1;
                        Console.WriteLine($"La parte entera de {num1} es {Enteronum1}");
                        break;

                    case "11":
                        Console.WriteLine("MAXIMO Y MINIMO ENTRE 2 NUMEROS");
                        Console.Write("Ingrese el primer numero a comparar: ");
                        ingreso1 = Console.ReadLine();
                        while (double.TryParse(ingreso1, out num1) == false)
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso1 = Console.ReadLine();
                        }

                        Console.Write("Ingrese el segundo numero a comparar: ");
                        ingreso2 = Console.ReadLine();
                        while (double.TryParse(ingreso2, out num2) == false) // Eliminado el num2 <= 0
                        {
                            Console.WriteLine("Error: Ingrese un numero valido.");
                            ingreso2 = Console.ReadLine();
                        }
                        Console.WriteLine($"El mayor es {Math.Max(num1, num2)} y el menor es {Math.Min(num1, num2)}");
                        break;

                    case "0":
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;
                    
                    default:
                        Console.WriteLine("Error: Opción no valida."); 
                        break;
                }
                
                if(eleccion != "0"){
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (eleccion != "0");
            break;
        }

        case "3":
        {
            Console.WriteLine(">>> EJERCICIO 4: MANEJO DE STRINGS <<<\n");
            
            Console.WriteLine("--- EXTRAER LONGITUD ---");
            Console.Write("Ingrese una cadena de texto: ");
            string cadenaIngresada = Console.ReadLine();
            Console.WriteLine($"- Longitud = {cadenaIngresada.Length}");

            Console.WriteLine("\n--- CONCATENAR 2 CADENAS ---");
            Console.Write("Ingrese una segunda cadena de texto: ");
            string ingresada2 = Console.ReadLine();
            string concatenar = string.Concat(cadenaIngresada, " ", ingresada2); 
            Console.WriteLine($"Cadena concatenada: {concatenar}");

            Console.WriteLine("\n--- EXTRAER SUBCADENA ---");
            if (cadenaIngresada.Length >= 4) 
            {
                string subcadena = cadenaIngresada.Substring(1, 3);    
                Console.WriteLine($"Subcadena extraida (desde pos 1, 3 caracteres) de la primera cadena: {subcadena}");
            }
            else
            {
                Console.WriteLine("La cadena es muy corta para extraer.");
            }

            Console.WriteLine("\n--- RECORRER CADENA ---");
            int i = 0;
            foreach (var caracter in cadenaIngresada)
            {
                Console.Write($"[{i}] {caracter}  ");
                i++;
            }
            Console.WriteLine();
            
            Console.WriteLine("\n--- BUSCAR OCURRENCIA ---");
            Console.Write("Ingrese la palabra que desea buscar en la primera cadena: ");
            string palabraBuscar = Console.ReadLine();

            if (cadenaIngresada.Contains(palabraBuscar))
            {
                Console.WriteLine($"La palabra '{palabraBuscar}' APARECE en la cadena.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabraBuscar}' NO fue encontrada.");
            }

            Console.WriteLine("\n--- CONVERTIR A MAYuSCULA Y MINuSCULA ---");
            Console.WriteLine($"Mayúscula: {cadenaIngresada.ToUpper()}");
            Console.WriteLine($"Minúscula: {cadenaIngresada.ToLower()}");

            Console.WriteLine("\n--- SEPARAR CADENA ---");
            Console.Write("Ingrese 3 palabras separadas por un guion (-): ");
            string palabra = Console.ReadLine();
            string[] separar = palabra.Split('-');
            int j = 0;
            foreach (var elemento in separar)
            {
                Console.WriteLine($"Palabra [{j}]: {elemento}");
                j++;
            }

            Console.WriteLine("\n--- CALCULADORA DE CADENAS ---");
            Console.Write("Ingrese la ecuacion (ej: 582 + 2): ");
            string ecuacion = Console.ReadLine();

            if (ecuacion.Contains('+'))
            {
                string[] partes = ecuacion.Split('+');
                if (double.TryParse(partes[0].Trim(), out num1) && double.TryParse(partes[1].Trim(), out num2))
                    Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
                else
                    Console.WriteLine("Error: Los valores no son validos.");
            }
            else if (ecuacion.Contains('-'))
            {
                string[] partes = ecuacion.Split('-');
                if (double.TryParse(partes[0].Trim(), out num1) && double.TryParse(partes[1].Trim(), out num2))
                    Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
                else
                    Console.WriteLine("Error: Los valores no son validos.");
            }
            else if (ecuacion.Contains('*'))
            {
                string[] partes = ecuacion.Split('*');
                if (double.TryParse(partes[0].Trim(), out num1) && double.TryParse(partes[1].Trim(), out num2))
                    Console.WriteLine($"El resultado de la multiplicacion es: {num1 * num2}");
                else
                    Console.WriteLine("Error: Los valores no son validos.");
            }
            else if (ecuacion.Contains('/'))
            {
                string[] partes = ecuacion.Split('/');
                if (double.TryParse(partes[0].Trim(), out num1) && double.TryParse(partes[1].Trim(), out num2))
                {
                    if (num2 != 0) Console.WriteLine($"El resultado de la division es: {num1 / num2}");
                    else Console.WriteLine("Error: No se puede dividir por cero.");
                }
                else
                    Console.WriteLine("Error: Los valores no son validos.");
            }
            else
            {
                Console.WriteLine("Error: operacion no reconocida. Ingrese +, -, * o /.");
            }

            break;
        }

        case "4":
        {
            Console.WriteLine(">>> EJERCICIO 5: EXPRESIONES REGULARES <<<\n");
            
            Console.Write("Ingrese un correo electronico para validar: ");
            string ingresoEmail = Console.ReadLine();
            string patronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (Regex.IsMatch(ingresoEmail, patronEmail))
                Console.WriteLine("El formato del correo electrónico es VALIDO!\n");
            else
                Console.WriteLine("Error: no parece un correo electronico real.\n");

            Console.Write("Ingrese una direccion web para validar (ej: https://ejemplo.com): ");
            string ingresoWeb = Console.ReadLine();
            string patronWeb = @"^(https?:\/\/)?([\w\d-]+\.)+[\w]{2,}(\/.*)?$";

            if (Regex.IsMatch(ingresoWeb, patronWeb))
                Console.WriteLine("El formato de la direccion web es VALIDO!");
            else
                Console.WriteLine("Error: Eso no parece una direccion valida.");
                
            break;
        }

        case "0":
            Console.WriteLine("\nSaliendo...");
            break;

        default:
            Console.WriteLine("\nError: opcion no valida. Intente nuevamente.");
            break;
    
    }

   

} while (opcionPrincipal != "0");