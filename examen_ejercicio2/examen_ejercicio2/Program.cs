String nombre,genero;
int edad;
Console.WriteLine("Nombre");
nombre=Console.ReadLine();
Console.WriteLine("Genero");
genero = Console.ReadLine();
Console.WriteLine("Edad");
edad = int.Parse(Console.ReadLine());

if(edad>17 && genero=="mujer")
{
    Console.WriteLine("eres la elegida");
}
else
{
    Console.WriteLine("no fuiste seleccionado");
}


