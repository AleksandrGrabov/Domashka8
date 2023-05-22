int[,,] array = CreateArray();
        PrintArrayWithIndices(array);
    
    static int[,,] CreateArray()
    {
        int[,,] array = new int[2, 2, 2];
        Random random = new Random();

        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    int number;
                    do
                    {
                        number = random.Next(10, 100);
                    } while (ArrayContains(array, number));

                    array[x, y, z] = number;
                }
            }
        }

        return array;
    }

    static bool ArrayContains(int[,,] array, int number)
    {
        foreach (int element in array)
        {
            if (element == number)
            {
                return true;
            }
        }

        return false;
    }

    static void PrintArrayWithIndices(int[,,] array)
    {
        for (int z = 0; z < 2; z++)
        {
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }