int size = 6;
string[] array = new string[size];
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Введите любые набор символов :");
for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine();
}
for (int i = 0; i < size; i++)
{

    Console.Write(" " + array[i]);
}
Console.WriteLine();
Console.WriteLine(" строковый массив меньше трёх");
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write(array[i] + " ");
    }
}

