// // 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
int m = 5;
int n = 5;
int[,] twoarray = new int [m, n];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            twoarray[i,j] = i + j;
            Console.Write (twoarray[i, j]);
        }
    }
            Console.WriteLine( " ");