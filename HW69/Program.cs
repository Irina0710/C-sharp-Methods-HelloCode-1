// 69. Найти сумму элементов от M до N, N и M заданы (с помощью рекурсии)
int sum = 0;
int Sum(int m,int n)
{
    if(m <=n)
    {
        return m+Sum(m+1,n);
    
    }
    return 0;
}

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());
Sum(m, n);
Console.WriteLine(Sum(m, n));
