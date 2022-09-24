// Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write(" введите число : ");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
int count = 1;
while(count <= num)
{
    Console.Write($"{Math.Pow(count, 3)}");
    if (count != num)
    Console.Write(", ");
    count ++;
}