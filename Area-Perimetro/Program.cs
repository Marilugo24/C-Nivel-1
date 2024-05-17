// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Introduzca la base del rectángulo");
int Base1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca la altura del rectángulo");
int Altura = int.Parse(Console.ReadLine());

Console.WriteLine("El perímetro del rectángulo es:" +(Base1+Altura+Base1+Altura));

Console.WriteLine("El área del rectángulo es:" +(Base1*Altura));