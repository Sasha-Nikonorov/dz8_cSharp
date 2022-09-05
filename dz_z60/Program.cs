int ReadInputData(string message)
{
    Console.WriteLine(message);
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

void CreateArray(int[,,] array)
{
    int[] arr = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        arr[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (arr[i] == arr[j])
            {
                arr[i] = new Random().Next(10, 100);
                j = 0;
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = arr[count];
                count++;
            }
        }
    }
}

void PrintArrayWithIdex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write("({0},{1},{2}) ", i, j, k);
            }
            Console.WriteLine();
        }
    }
}

int x = ReadInputData("Введите X: ");
int y = ReadInputData("Введите Y: ");
int z = ReadInputData("Введите Z: ");
int maxNumb = 90;
int min = x * y * z;
if (min > maxNumb || x <= 0 || y <= 0 || z <= 0)
{
    Console.Write("Невозможно создать массив");
    return;
}
Console.WriteLine();

var array = new int[x, y, z];
CreateArray(array);
PrintArrayWithIdex(array);
