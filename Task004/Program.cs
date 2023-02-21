/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int GetRandom()
{
    int[] numbers = new int[90]; //это магическое число, но я не знаю как задать его лучше. вэто количество всех двухзначных чисел.
    Random rnd = new Random();
    
    for (int m = 0; m < numbers.Length; m++)
    {
        numbers[m] = rnd.Next(10, 100);     
    }
    
    int value = rnd.Next(10, 100);
    for (int l = 0; l < numbers.Length; l++)
    {

        while (value == numbers[l]) value = rnd.Next(10, 100);
        
    }

    return value;

}
    


int[,,] Init3DMatrix()
{
    int[,,] matrix = new int[2, 2, 2];
          
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = GetRandom();

            }
            
        }
    }

    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                 Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int[,,] matrix = Init3DMatrix();
Print3DMatrix(matrix);

