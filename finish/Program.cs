string[] array1 = new string[5] {"Hello", "98", ";-)", "78954", "0"};
string[] array2 = new string[array1.Length];

void SortingAnArray(string[] array1, string[] array2)
{
    int meaning = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[meaning] = array1[i];
        meaning++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}