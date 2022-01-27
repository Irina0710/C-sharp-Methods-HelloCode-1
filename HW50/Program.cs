// 50. В двумерном массиве n×k заменить четные элементы на противоположные
int k = 4;
int n = 4;
int[,] twoarray = new int [k, n];

{
    for (int i = 0; i < k; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            twoarray[i,j] = new Random().Next(1, 10);
            Console.Write (twoarray[i,j]);
            Console.Write( " ");
        }
    }
}
for (int i = 0; i < k; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            if (twoarray[i,j]%2 == 0)twoarray[i,j] = -twoarray[i,j];
            Console.WriteLine();
            Console.WriteLine(twoarray[i,j]);

        }

    }