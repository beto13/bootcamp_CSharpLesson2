// See https://aka.ms/new-console-template for more information
Console.WriteLine("Por favor ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese su apellido: ");
string apellido = Console.ReadLine();

Console.WriteLine("Por favor ingrese su edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

string mensaje = $"Hola " + nombre +apellido;

Console.WriteLine(mensaje);

Console.ReadKey();