int[,] array = new int[4, 4];
int num = 1;
int top = 0, bottom = 3, left = 0, right = 3;

while (num <= 16)
{
    for (int i = left; i <= right; i++)
    array[top, i] = num++;

    top++;

    for (int i = top; i <= bottom; i++)
    array[i, right] = num++;

    right--;

    for (int i = right; i >= left; i--)
    array[bottom, i] = num++;

    bottom--;

    for (int i = bottom; i >= top; i--)
    array[i, left] = num++;

    left++;
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(array[i, j].ToString("D2") + " ");
    }
    Console.WriteLine();
}