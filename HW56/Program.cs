// 56. Написать программу, которая обменивает элементы первой строки и последней строки
int[,]matrix = new int[4, 4];

void PrintFillArray(int[,] matrix)
{
    for  (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,12);
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
PrintFillArray(matrix);
System.Console.WriteLine();

int row = matrix.GetLength(0); //нашли кол-во строк
for  (int i = 0; i < matrix.GetLength(1); i++) //matrix.GetLength(1) - колво столбцов
    {
        int temp = matrix[0,i]; //int temp = matrix[0,0] - первый элемент в первой строке
        matrix[0,i] = matrix[row-1, i]; //matrix[row-1, 0] - первый элемент в последней строке
        matrix[row-1, i] = temp; // matrix[row-1, 0] = temp;
    }
for  (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.WriteLine($"{matrix[i, j]} ");
        }
      System.Console.WriteLine();
    }  
