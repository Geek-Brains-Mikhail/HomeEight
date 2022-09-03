// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
Console.Clear();
void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void OrderElementInlLine(int[,] array)
{
    int min =0;
    int temporary = 0;
    int minIndexJ  =0;
    int minindexI =0;
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min = array[i,j];
            minIndexJ = j;
            minindexI = i;
            for (int k = count; k < array.GetLength(1); k++)
            {
                if(min  > array[i,k])
                {
                    min = array[i,k];
                    minIndexJ = k;
                    minindexI = i;
                }
            }
            temporary = array[i,j];
            array[i,j] = min;
            array[minindexI,minIndexJ] = temporary;
            count++;
        }
        count = 0;
    }
}
int[,] array = new int[3,4];
FillArray(array);
PrintArray(array);
OrderElementInlLine(array);
Console.WriteLine();
PrintArray(array);
