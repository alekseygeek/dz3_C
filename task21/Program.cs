// Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("введите координату X первой точки: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("введите координату Y первой точки: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("введите координату Z первой точки: ");
int z = int.Parse(Console.ReadLine()!);
Console.Write("введите координату X второй точки: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("введите координату Y второй точки: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("введите координату Z второй точки: ");
int z1 = int.Parse(Console.ReadLine()!);

int A = x - x1;
int B = y - y1;
int C = z - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
length = Math.Round(length, 2);
Console.WriteLine($"длинна отрезка {length}");
