/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пальзоваться коллекциями,
лучше обойтись исключительно массивами.*/ 

string[] StartArray = {"hello", "2", "world", ":-)"};

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
PrintArray(StartArray);
