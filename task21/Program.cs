// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double x1 = Prompt("Введите x1: ");
double y1 = Prompt("Введите y1: ");
double z1 = Prompt("Введите z1: ");
double x2 = Prompt("Введите x2: ");
double y2 = Prompt("Введите y2: ");
double z2 = Prompt("Введите z2: ");

double Prompt(string message)
{
    Console.Write(message);
    double coordNumber = double.Parse(Console.ReadLine()!);
    return coordNumber;
}
Console.WriteLine(Math.Sqrt((Math.Pow((x2-x1),2)) + (Math.Pow((y2-y1),2)) + (Math.Pow((z2-z1),2))));