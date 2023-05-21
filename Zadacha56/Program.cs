int[,] array = {
        { 1, 4, 7, 2 },
        { 5, 9, 2, 3 },
        { 8, 4, 2, 4 },
        { 5, 2, 6, 7 }
    };

    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    int minSumRowIndex = RowWithMinSum(array);

    Console.WriteLine("\nСтрока с наименьшей суммой элементов: " + (minSumRowIndex + 1) + " строка");

    static int RowWithMinSum(int[,] array)
{
    int minSumRowIndex = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }

    return minSumRowIndex;
}

static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}