// Задача 3: Задайте произвольный массив.
//Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.

int[] FillArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}
void ReversPrint(int[] arr, int start)
{
    if (start == 0) Console.WriteLine(arr[0]);
    else
    {
        Console.Write($"{arr[start]}, ");
        ReversPrint(arr, start-1);
    }
}
int[] arr = FillArray(10);

Console.WriteLine($"[{String.Join(", ", arr)}]");
ReversPrint(arr, arr.Length-1);