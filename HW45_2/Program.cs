// 45. Показать числа Фибоначчи
// 0, 1, 1, 2, 3, 5, 8, 13, 21
//последовательность, где первые 2 числа равны 1 и 1, или 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел.
int n = 1;
int n2 = 1;
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n);
Console.WriteLine(n2);
while (n < num)
{
   int fib = n + n2;
   n = n2;
   n2 = fib;
   if (n2 >= num) break;
    Console.WriteLine(fib);
}

