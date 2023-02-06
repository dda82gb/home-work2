// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
int x1 = Coordinate("Введите координату для точки A1: ");
int y1 = Coordinate("Введите координату для точки A2: ");
int z1 = Coordinate("Введите координату для точки A3: ");
int x2 = Coordinate("Введите координату для точки B1: ");
int y2 = Coordinate("Введите координату для точки B2: ");
int z2 = Coordinate("Введите координату для точки B3: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length =  Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);
 
int Coordinate (string mes)

{
    Console.Write(mes);
    return int.Parse(Console.ReadLine());
}