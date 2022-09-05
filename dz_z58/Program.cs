int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(2, 6);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < martrix1.GetLength(1); k++)
            {
                sum += martrix1[i, k] * martrix2[k, j];
            }
            result[i, j] = sum;
        }
    }
}

int ReadInputData(string message)
{
    Console.WriteLine(message);
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

int numberOfRows = ReadInputData("Введите число строк первой матрицы");
int numberOfRowsAndColumns = ReadInputData("Введите число столбцов первой и строк второй матрицы");
int numberOfColumns = ReadInputData("Введите число столбцов второй матрицы");

if (numberOfRows <= 0 || numberOfColumns <= 0 || numberOfRowsAndColumns <= 0)
{
    Console.Write("Невозможно создать массив");
    return;
}
Console.WriteLine();

var martrix1 = CreateArrayWithRandomNumbers(numberOfRows, numberOfRowsAndColumns);
Console.WriteLine("Первая матрица :");
PrintArray(martrix1);
Console.WriteLine();

var martrix2 = CreateArrayWithRandomNumbers(numberOfRowsAndColumns, numberOfColumns);
Console.WriteLine("Вторая матрица:");
PrintArray(martrix2);
Console.WriteLine();

var result = new int[numberOfRows, numberOfColumns];

MultiplyMatrix(martrix1, martrix2, result);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(result);