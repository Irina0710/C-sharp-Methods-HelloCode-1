// Задача 55

// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int m = 3;
int n = 4;
int [,] matrix = new int [m,n];

void Matrix (int [,] matrix)
{
    for (int i=0; i< matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(1,10);
                Console.Write(matrix[i,j]);
                Console.Write(" ");
            }
        Console.WriteLine();
        }
}

void averageAtColumns (int [,] matrix)
{
    int sum = 0;
    for (int j=0; j< matrix.GetLength(1);j++)
    {
        for (int i=0; i<matrix.GetLength(0);i++)
        {
            sum = sum+matrix [i,j];
        }
        Console.Write($"{sum/m} ");
        sum = 0;
    }
    
}
Matrix (matrix);
Console.WriteLine("Average:");
averageAtColumns (matrix);

