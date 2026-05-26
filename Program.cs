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

// hacer menu de eleccion de enunciado
