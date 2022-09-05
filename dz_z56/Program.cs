int ReadInputData(string message)
{
    Console.WriteLine(message);
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}

void PrintArray1(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}
// void PrintArray2(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}");
//         if (i == arr.Length - 1) Console.Write("");
//         else Console.Write(", ");
//     }
// }

int[] SumElements(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    int index = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            result[index] = sum;

        }
        // Console.WriteLine($"Сумма {i+1} строки = {sum}. ");
        index++;
        sum = 0;
    }
    return result;
}

void MinElement(int[] array)
{
    int min = array[0];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            result = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов находится на {result + 1} строке");
}

int numberOfRows = ReadInputData("Введите число строк (m)");
int numberOfColumns = ReadInputData("Введите число столбцов (n)");
if (numberOfRows == numberOfColumns)
{
    Console.WriteLine("Задайте прямоугольный двумерный массив!");
    return;
}
else if (numberOfRows <= 0 || numberOfColumns <= 0)
{
    Console.Write("Невозможно создать массив");
    return;
}

var array = CreateArrayWithRandomNumbers(numberOfRows, numberOfColumns);
Console.WriteLine();
PrintArray1(array);
// Console.WriteLine();
var array2 = (SumElements(array));
// PrintArray2(array2);
// Console.WriteLine();
MinElement(array2);