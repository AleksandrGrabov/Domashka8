    int[,] array = {
        { 1, 4, 7, 2 },
        { 5, 9, 2, 3 },
        { 8, 4, 2, 4 }
    };

    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    SortRows(array);

    Console.WriteLine("Массив после упорядочивания строк по убыванию:");
    PrintArray(array);

static void SortRows(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxIndex = j;

            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxIndex])
                {
                    maxIndex = k;
                }
            }

            int temp = array[i, j];
            array[i, j] = array[i, maxIndex];
            array[i, maxIndex] = temp;
        }
    }
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