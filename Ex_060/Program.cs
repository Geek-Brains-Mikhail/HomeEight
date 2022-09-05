// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
Console.Clear();
void FillArray(int[,,] array)
{
    Random rand = new Random();
    bool isWork = true;
    int index = 0;
    int[] ArrayTwoDeminsional = new int[8];
    int numberRandom = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int o = 0; o < array.GetLength(2); o++)
            {
                while (isWork)
                {
                    numberRandom = rand.Next(1, 11);
                    for (int l = 0; l < ArrayTwoDeminsional.Length; l++)
                    {
                        if (numberRandom == ArrayTwoDeminsional[l])
                        {
                            isWork = false;
                            l = ArrayTwoDeminsional.Length;
                        }

                    }
                    if (isWork == true)
                    {
                        ArrayTwoDeminsional[index] = numberRandom;
                        array[i, j, o] = numberRandom;
                        Console.WriteLine($"{array[i, j, o]} ({i},{j},{o})");
                        isWork = false;
                    }
                    else
                    {
                        isWork = true;
                    }
                }
                index++;
                isWork = true;
            }
        }
    }
}
int[,,] arrayThreeDimensional = new int[2, 2, 2];
FillArray(arrayThreeDimensional);
