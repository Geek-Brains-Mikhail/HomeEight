// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
void FillArray(int[,] array)
{
    int count = 1;
    int number = 0;
    if (count == 1)
    {
        for (int j = number; j < array.GetLength(1); j++)
        {
            array[array.GetLength(0)-4, j] = count++;
        }
    }
    if (count == 5)
    {
        for (int f = 1; f < array.GetLength(0); f++)
        {
            array[f, array.GetLength(1) - 1] = count++;
        }

    }
    if (count == 8)
    {
        for (int k = array.GetLength(1) - 2; k >= 0; k--)
        {
            array[array.GetLength(0) - 1, k] = count++;
        }

    }
    if (count == 11)
    {
        for (int k = array.GetLength(0) - 2; k >= 1; k--)
        {
            array[k, array.GetLength(0) - 4] = count++;
        }
    }
    if (count == 13)
    {
        for (int k = array.GetLength(1) - 3; k <= 2; k++)
        {
            array[array.GetLength(0) - 3, k] = count++;
        }
    }
    if (count == 15)
    {
        for (int k = 2; k < 3; k++)
        {
            array[2, k] = count++;
        }
    }
    if (count == 16)
    {
        array[2, 1] = 16;
    }
}
void PrintArray(int[,] array)
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
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
