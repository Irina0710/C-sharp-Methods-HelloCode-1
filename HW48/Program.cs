// 48. Показать двумерный массив размером m×n заполненный целыми числами
int m = 5;
int n = 4;
int[,] twoarray = new int [m, n];
for (int i = 0; i < m; ++i) // выводим на экран строку i
{
    for (int j = 0; j < n; ++j) // выводим на экран столбец j
    {
        twoarray [i,j] = new Random().Next(1,10);
        Console.Write(twoarray [i,j]);
        Console.Write( " ");
    }
    Console.WriteLine();
}
