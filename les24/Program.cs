﻿// ===== Работа с текстом
// Дан текст . 
// Маленькие буквы "k"заменить большими "К" ,
// а большие "С" заменить маленькими .
Console.Clear();
string text = "Всеми любимые стихи классиков были написаны давно, но все равно не теряют своей          "
            + "актуальности и важности в нашей жизни. С помощью поэзии Вы сможете не только найти ответы"
            + "на вопросы, которые так сильно Вас тревожат, но также и замечательно .                   "
            + "провести время, понять себя, а также окружающих и дорогих Вам людей .                    ";

            
// string s = " qwert"
//              01234
// s [4] // t-4 cимвол
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ','*');
Console.WriteLine(newText);
Console.WriteLine("привет");


// МАССИВЫ

/*int[] arr = { 1, 4, 6, 3, 8, 9, 12, 45, 2, 3, };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);*/