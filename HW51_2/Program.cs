//  51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

void CreateMatrix2Way (int [,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j;
        }
    }
}

//вывод двумероного массива
void PrintMatrix (int [,] matrix)

{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ") ;
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}
    
 Console.WriteLine("Введите число строк двумерного массива");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число столбцов двумерного массива");
 int k = Convert.ToInt32(Console.ReadLine());
 int [,] matrix = new int [n,k];
 CreateMatrix2Way (matrix);
 PrintMatrix (matrix);
