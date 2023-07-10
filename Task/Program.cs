// Задача: Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, длина которых
// меньше, либо равна 3 символам. Первоначальный массив можно
// ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] CreateNewArray(string[] array)
{
    string[] newArray = new string[] { };

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3) newArray = newArray.Append(array[j]).ToArray();
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}

Console.Write("Введите количество строк в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size <= 0) Console.Write("Число должно быть больше нуля!");
else PrintArray(CreateNewArray(CreateArray(size)));