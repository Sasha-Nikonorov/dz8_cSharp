int ReadInputData(string message)
{
    Console.WriteLine(message);
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

void SpiralArray(int[,] array, int size)
{
    int i = 0;
    int j = 0;
    for (int count = 1; count <= size * size; count++)
    {
        array[i, j] = count;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"{0}{array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int size = ReadInputData("Введите размер массива");
if (size <= 0)
{
    Console.Write("Невозможно создать массив");
    return;
}
var array = new int[size, size];

SpiralArray(array, size);
PrintArray(array);