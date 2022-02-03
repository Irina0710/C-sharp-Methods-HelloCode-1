// Показать натуральные числа от M до N, N и M заданы (с помощью рекурсии)
void PrintNumbers(int n, int i)
{
    Console.Write($"{i} ");
    if (i != n)
        PrintNumbers (n,i+1);
} 
Console.WriteLine("Введите второе число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());
PrintNumbers(N, M);

