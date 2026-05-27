// PUNTO 0
Console.WriteLine("Hello, World!"); 
int a; 
int b; 
a=10; 
b=a; 
Console.WriteLine("valor de a:"+a); 
Console.WriteLine("valor de b:"+b);

// PROBLEMA 1
    string textoBuscado = Console.ReadLine();
    int numero;
do
{
    Console.Write("Ingrese un número mayor a 0: ");


    if (int.TryParse(textoBuscado, out numero))
    {
        if (numero > 0)
        {
            for (int i = textoBuscado.Length-1; i >= 0 ; i--)
            {
                Console.Write($"{textoBuscado[i]}");            
            }   
        } else
        {
           Console.WriteLine("El numero ingresado es menor a 0. Intente nuevamente");    
        }
    } else
    {
        Console.WriteLine("Por favor, ingrese un numero. Intente nuevamente");
    }
} while (numero <= 0 );

// PROBLEMA 2
string eleccion,ingreso1,ingreso2;
double num1,num2;
do
{
    Console.WriteLine("");
    Console.WriteLine("-------- CALCULADORA --------");
    Console.WriteLine("¿Qué operación desea realizar?");
    Console.WriteLine("1 = Suma");
    Console.WriteLine("2 = Resta");
    Console.WriteLine("3 = Multiplicación");
    Console.WriteLine("4 = División");
    Console.WriteLine("5 = Valor Absoluto de un numero");
    Console.WriteLine("6 = Cuadrado de un numero");
    Console.WriteLine("7 = Raiz de un numero");
    Console.WriteLine("8 = Seno de un numero");
    Console.WriteLine("9 = Coseno de un numero");
    Console.WriteLine("10 = Parte entera de un numero decimal");
    Console.WriteLine("0 = SALIR");
    Console.WriteLine("------------------------------");
    Console.WriteLine("");
    
    Console.Write("Ingrese: ");
    eleccion = Console.ReadLine();

    
    switch (eleccion)
    {
        case "1":
            Console.Write("Ingrese el primer numero a sumar (_ + ): ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese el primer numero a sumar (_ + ): ");
                ingreso1 = Console.ReadLine();
            }

            Console.Write($"Ingrese el segundo numero a sumar ({num1} + _): ");
            ingreso2 = Console.ReadLine();

            while (double.TryParse(ingreso2, out num2) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write($"Ingrese el segundo numero a sumar ({num1} + _): ");
                ingreso2 = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine($"    {num1}");
            Console.WriteLine("+");
            Console.WriteLine($"    {num2}");
            Console.WriteLine("  __________");
            Console.WriteLine($"    {num1 + num2}");
            Console.WriteLine("");
            
            break;
        case "2":
            Console.Write("Ingrese el primer numero a restar (_ - ): ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese el primer numero a restar (_ - ): ");
                ingreso1 = Console.ReadLine();
            }

            Console.Write($"Ingrese el segundo numero a restar ({num1} - _): ");
            ingreso2 = Console.ReadLine();

            while (double.TryParse(ingreso2, out num2) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write($"Ingrese el segundo numero a restar ({num1} - _): ");
                ingreso2 = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine($"    {num1}");
            Console.WriteLine("-");
            Console.WriteLine($"    {num2}");
            Console.WriteLine("  __________");
            Console.WriteLine($"    {num1 - num2}");
            Console.WriteLine("");
            
            break;        
        case "3":
            Console.Write("Ingrese el primer numero a multiplicar (_ * ): ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese el primer numero a multiplicar (_ * ): ");
                ingreso1 = Console.ReadLine();
            }

            Console.Write($"Ingrese el segundo numero a multiplicar ({num1} * _): ");
            ingreso2 = Console.ReadLine();

            while (double.TryParse(ingreso2, out num2) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write($"Ingrese el segundo numero a multiplicar ({num1} * _): ");
                ingreso2 = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine($"    {num1}");
            Console.WriteLine("*");
            Console.WriteLine($"    {num2}");
            Console.WriteLine("  __________");
            Console.WriteLine($"    {num1 * num2}");
            Console.WriteLine("");
            
            break;        
        case "4":
            Console.Write("Ingrese el primer numero a dividir (_ / ): ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese el primer numero a dividir (_ / ): ");
                ingreso1 = Console.ReadLine();
            }

            Console.WriteLine($"Ingrese el segundo numero a dividir ({num1} / _) ");
            Console.WriteLine("IMPORTANTE: EL NUMERO DEBE SER MAYOR O IGUAL QUE 0");
            ingreso2 = Console.ReadLine();

            while (double.TryParse(ingreso2, out num2) == false || num2 <= 0)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.WriteLine($"Ingrese el segundo numero a dividir ({num1} / _) ");
                Console.WriteLine("IMPORTANTE: EL NUMERO DEBE SER MAYOR O IGUAL QUE 0");
                ingreso2 = Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine($"    {num1}");
            Console.WriteLine("/");
            Console.WriteLine($"    {num2}");
            Console.WriteLine("  __________");
            Console.WriteLine($"    {num1 / num2}");
            Console.WriteLine("");
            
            break;   
        case "5":
            Console.Write("Ingrese un numero: ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese un numero: ");
                ingreso1 = Console.ReadLine();
            }
    
            Console.WriteLine($"|{num1}| = {Math.Abs(num1)}");

            break;
        case "6":
            Console.Write("Ingrese un numero: ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese un numero: ");
                ingreso1 = Console.ReadLine();
            }
    
            Console.WriteLine($"El cuadrado de {num1} es: {Math.Pow(num1, 2)}");

            break;
        case "7":
            Console.Write("Ingrese un numero ");
            Console.WriteLine("IMPORTANTE: EL NUMERO DEBE SER MAYOR O IGUAL QUE 0");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false || num1 <= 0)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese un numero ");
            Console.WriteLine("IMPORTANTE: EL NUMERO DEBE SER MAYOR O IGUAL QUE 0");
                ingreso1 = Console.ReadLine();
            }
    
            Console.WriteLine($"La raíz cuadrada de {num1} es: {Math.Sqrt(num1)}");

            break;
        case "8":
            Console.Write("Ingrese un numero: ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese un numero: ");
                ingreso1 = Console.ReadLine();
            }
    
            Console.WriteLine($"sen({num1}) = {Math.Sin(num1)}");

            break;
        case "9":
            Console.Write("Ingrese un numero: ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese un numero: ");
                ingreso1 = Console.ReadLine();
            }
    
            Console.WriteLine($"cos({num1}) = {Math.Cos(num1)}");

            break;
        case "10":
            Console.Write("Ingrese un numero: ");
            ingreso1 = Console.ReadLine();

            while (double.TryParse(ingreso1, out num1) == false)
            {
                Console.WriteLine("Error: Por favor, ingrese un numero válido.");
                Console.Write("Ingrese un numero: ");
                ingreso1 = Console.ReadLine();
            }
    
            int Enteronum1 = (int)num1;
            Console.WriteLine($"La parte entera de {num1} es {Enteronum1}");

            break;
        case "0":
            Console.WriteLine("Saliendo de la calculadora...");
            break;
        
        default:
            // ingresa un valor no admitido
            Console.WriteLine("Error: Opción no válida. Intente nuevamente"); 
            break;
    }

} while (eleccion != "0"); // no convierto a numero la eleccion ya que solo comparo, lo trabajo como string

// EJERCICIO 3
Console.WriteLine("MAXIMO ENTRE 2 NUMEROS");
Console.Write("Ingrese el primer numero a comparar: ");
ingreso1 = Console.ReadLine();

while (double.TryParse(ingreso1, out num1) == false)
{
    Console.WriteLine("Error: Por favor, ingrese un numero válido.");
    Console.Write("Ingrese el primer numero a comparar: ");
    ingreso1 = Console.ReadLine();
}

Console.WriteLine("Ingrese el segundo numero a comparar: ");
ingreso2 = Console.ReadLine();

while (double.TryParse(ingreso2, out num2) == false || num2 <= 0)
{
    Console.WriteLine("Error: Por favor, ingrese un numero válido.");
    Console.Write("Ingrese el segundo numero a comparar: ");
    ingreso2 = Console.ReadLine();
}

Console.WriteLine($"El mayor valor entre {num1} y {num2} es {Math.Max(num1, num2)} y el menor es {Math.Min(num1, num2)}");

