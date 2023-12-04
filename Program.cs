/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры*:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


string[] CreateArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        string element = Console.ReadLine();
        array[i] = element;
    }
    Console.WriteLine($"Введенные данные: [{string.Join(", ", array)}]");
    return array;
}

string[] FindElementArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Console.WriteLine($"Найденные элементы, длина которых меньше 4-х: [{string.Join(", ", newArray)}]");
    return newArray;
}


Console.Write("Введите количество элементов: ");
int length = int.Parse(Console.ReadLine()!);
