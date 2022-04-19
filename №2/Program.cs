//Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("x1: ");
int x1 = Coordinate("x","A");
int y1 = Coordinate("y","A");
int z1 = Coordinate("z","A");
int x2 = Coordinate("x","B");
int y2 = Coordinate("y","B");
int z2 = Coordinate("z","B");

double distance;

distance = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
Console.WriteLine($"Расстояние между точками = {distance}");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} ");
    return Convert.ToInt16(Console.ReadLine());
}
