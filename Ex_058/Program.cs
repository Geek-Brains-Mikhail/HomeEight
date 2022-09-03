// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
Console.Clear();
void FillMatrix(int[,] matr1, int[,] matr2)
{
    Random rand = new Random();
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = rand.Next(1, 10);
            matr2[i, j] = rand.Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matr1)
{
    Random rand = new Random();
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            Console.Write(matr1[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] MultiplicationMatrices(int[,] matr1,int[,] matr2)
{
    int[,] matrixMultiplication = new int[matr1.GetLength(0),matr1.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matrixMultiplication[i,j] = matr1[i,j] * matr2[i,j];
        }
    }
    return matrixMultiplication;
}
int[,] matrixFirst = new int[4, 4];
int[,] matrixSecond = new int[4, 4];
FillMatrix(matrixFirst,matrixSecond);
PrintMatrix(matrixFirst);
Console.WriteLine();
PrintMatrix(matrixSecond);
int[,] matrixMultiplicationMatrices = MultiplicationMatrices(matrixFirst,matrixSecond);
Console.WriteLine();
PrintMatrix(matrixMultiplicationMatrices);