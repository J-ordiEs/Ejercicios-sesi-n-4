//Ejercicio 1 - While

string msg = "Ingrese el numero que desea saber su tabla de multiplicar";
Console.WriteLine(msg);
int inputNum = Convert.ToInt32(Console.ReadLine());
int result = 0;
int count = 1;

while(count <= 10)
{
    result = count * inputNum;
    Console.WriteLine($@" {inputNum}x{count} = {result}");
    count++;
}

//Ejercicio 2 - Do while

Console.WriteLine(@"ingresa algunos numeros que desees saber si es positivo o negativo
¿Cuantos numeros deseas evaluar?");

int times = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{times} veces, Empecemos ingresando los numeros que deseas evaluar");

int inputNumero = 0;
count = 0;

do
{
    inputNumero = Convert.ToInt32(Console.ReadLine());
    
    if(inputNumero == 0)
    {
        Console.WriteLine("Su Numero es 0 no es positivo pero tampoco negativo.");
    }
    else if(inputNumero >= 1)
    {
        Console.WriteLine($@"Su numero '{inputNumero}' es Positivo.");
    }
    else if(inputNumero <= -1)
    {
        Console.WriteLine($@"Su numero '{inputNumero}' es Negativo.");
    }
    count++;
}
while(count < times);

//Ejercicio 3 - For

Console.WriteLine(@"Vamos a dibujar un cuadro con los datos ingresados.
Ingrese el ancho deseado");    
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ahora ingrese el alto de la figura");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cuantas figuras quiere ver en pantalla");
int amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@"¿Quiere que tenga relleno? S=si o N=no");
string? fill = Console.ReadLine();
Console.WriteLine($"ancho {width}, alto {height}, cantidad de figuras {amount}, ¿Con relleno? {fill}");

for(int i = 1; i <= amount; i++ )
{
    for(int row = 1; row <= height; row++)
    {
        for(int column = 1; column <= width; column++)
        {
            if(row == 1 || row == height)
            {
                Console.Write("@");
            }
            else
            {
                if (column == 1 || column == width)
                {
                    Console.Write("@");
                }
                else if(fill == "s" || fill == "S")
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write(" ");
                }

            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

