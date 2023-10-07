// See https://aka.ms/new-console-template for more information
Console.WriteLine("\tAlgoritmo para mostrar asteríscos escalonados pegados a la derecha");
Console.WriteLine("\t******************************************************************\n");
string palabra;
int num;
int a = 0; //Para saber si se coloca o no 'STOP' o no

do
{
    Console.Write(" Ingrese un número: ");
    palabra = Console.ReadLine()!;
    Console.WriteLine();

    if (palabra.ToUpper() != "STOP")
    {
        num = int.Parse(palabra);        
        //"for" para la figura en general
        for (int filas = 0; filas <= num; filas++)
        {
            //"for" para los espacios en blanco (se debe colocar el número que se ingresa como el máximo
            //para que luego vaya disminuyendo los espacios, que comienza con una cantidad igual al número
            //mientras va aumentando las filas)
            for (int espacio = num; espacio >= filas; espacio--)
            {
                Console.Write(" ");                                     
            }
            //"for" para los asterícos que siguen y no llevan a otra línea. Compilar paso a paso si no se entiende el código
            for (int asteriscos = 1; asteriscos <= filas; asteriscos++)
            {
                Console.Write("*");
            }            
            Console.WriteLine("*");
        }
    }    
    else
        a = -1;
    Console.WriteLine();

} while (a != -1);