Console.WriteLine("Введите колличество число");
int number = int.Parse(Console.ReadLine()!);
int[] array = CreateArray(number);
PrintArray(array);
int result = NumbersGreaterZero(array);
Console.WriteLine(result);

int[] CreateArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NumbersGreaterZero(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}