Console.WriteLine("Введите размерность матрицы (количество строк и столбцов):");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix1 = CreateRandomMatrix(size);
        int[,] matrix2 = CreateRandomMatrix(size);

        Console.WriteLine("Первая матрица:");
        PrintMatrix(matrix1);

        Console.WriteLine("Вторая матрица:");
        PrintMatrix(matrix2);

        int[,] result = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("Результат умножения матриц:");
        PrintMatrix(result);
    
    static int[,] CreateRandomMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        return matrix;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int size = matrix1.GetLength(0);
        int[,] result = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
