/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

int[] GetSum (int[,] matrix)
{   
   int[] arraySum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        int rowSum = 0;
            

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            rowSum = rowSum + matrix[i, j];         
        }

        arraySum[i] = rowSum;
                                 
    }
    return arraySum;
}

void FindMin(int[] sumArray)
{
    int minArraySum = sumArray[0];
    int minArraySumPos = 0;

    for (int k = 0; k < sumArray.Length; k++)
    {
        
        if (sumArray[k] < minArraySum)
        {
            minArraySum = sumArray[k];
            minArraySumPos = k;
        }
                
    }
    Console.Write($"Строка с наименьшей суммой элементов: {minArraySumPos+1} строка ");
}

int[,] matrix = InitMatrix(3, 4);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumArray = GetSum(matrix);
FindMin(sumArray);