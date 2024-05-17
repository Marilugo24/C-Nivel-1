// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Introduzca su dia de nacimiento");
int Dia = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca su mes de nacimiento");
int Mes = int.Parse(Console.ReadLine());


if(Dia>22 && Mes>=11){
    Console.WriteLine("Tu signo zodiacal es Sagitario");
}

else if(Dia<21 && Mes<=11){
    Console.WriteLine("Tu signo es Escorpio");
}

if(Dia>28 && Mes<11){
    Console.WriteLine("Tu signo es Capricornio");
}