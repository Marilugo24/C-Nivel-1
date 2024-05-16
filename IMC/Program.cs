// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Introduzca su Peso");
float Peso=float.Parse(Console.ReadLine());

Console.WriteLine("Introduzca su Altura");
float Altura=float.Parse(Console.ReadLine());

float Resultado=Peso/(Altura*Altura);
Console.WriteLine("El IMC es:" +Resultado);

if((Peso<=40) && (Altura<=1.70)){
    Console.WriteLine("Estas por debajo de tu peso");
}

else if((Peso>=65) && (Altura>=1.61)){
    Console.WriteLine("Estas en tu peso ideal");
}

if((Peso>=80) && (Altura<=1.5)){
    Console.WriteLine("Estas Obeso");
}




