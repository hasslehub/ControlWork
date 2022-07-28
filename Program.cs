void FindFromArray(string[] array)
{
    string[] finalArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            finalArray[i] = array[i];
        }
    }
    Console.Write("Результат: ");
    PrintArray(finalArray);
}

void PrintArray(string[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} ");
    }
    Console.WriteLine();
}

string[] mainArray = { "hello", "2", "world", ":-)" };
Console.WriteLine();
Console.Write("Первоначальный массив: ");
PrintArray(mainArray);

FindFromArray(mainArray);
Console.WriteLine();

