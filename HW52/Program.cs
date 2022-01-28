// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int k = 4;
int n = 4;

int [,] twoarray = new int [k,n];

for (int i = 0; i < k; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            twoarray[i,j] = new Random().Next(1,10);
            Console.Write (twoarray[i, j]);
            Console.Write( " ");
        }
        Console.WriteLine();
    }
for (int i = 0; i < k; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            if (i %2 == 0 && j %2 == 0) twoarray[i,j] = twoarray[i,j] * twoarray[i,j];
            twoarray[i,j] = new Random().Next(1,10);
            Console.Write (twoarray[i, j]);
            Console.Write( " ");
        }
        Console.WriteLine();
    }


