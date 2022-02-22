/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пальзоваться коллекциями,
лучше обойтись исключительно массивами.*/ 

//string[] StartArray = {"hello", "2", "world", ":-)"};
string[] StartArray = {"Russia", "Kazan", "Denmark"};

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i != array.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");
}

int NewArraySize(string[] array)
{
    int numberForSize = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i].Length < 4)
            numberForSize++;
    }
    return numberForSize;
}

string[] CreateNewArray(string[] array, int newArraySize)
{
    string[] NewArray = new string[newArraySize];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            NewArray[j] = array[i];
            j++;
        }
    }
    return NewArray;
}

PrintArray(StartArray);
//int newArraySize = NewArraySize(StartArray);
string[] newArray = CreateNewArray(StartArray, NewArraySize(StartArray));
Console.Write("->");
PrintArray(newArray);
