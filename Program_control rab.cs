// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]



string[] arr = {"hello", "2", "world", ":-)", "aaaaa"};

int m = arr.Length;

Console.WriteLine($"Первоначальный массив");

Console.WriteLine(PrintArray(arr));

Console.WriteLine($"Сформированный массив");

NewArray(arr);

string[] result = new string[m];

void NewArray(string[] array)
{
    int m = array.Length;
    string[] result = new string[m];
    Console.Write($"[");
    for (int i = 0; i < m; i++)
    {
       if (array[i].Length <= 3)
       {
        result[i] = array[i];
        Console.Write(result[i] );
       }
    } 
    Console.WriteLine($"]");
    Console.WriteLine();       
}

string PrintArray(string[] array)
{
    int m = array.Length;
    string result = string.Empty;
    result = "[";
    for (int i = 0; i < m; i++)
    {
       result += $"{array[i],2} ";
    }
    result += "]"; 
    return result;  
}


