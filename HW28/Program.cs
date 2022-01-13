// 28. Подсчитать сумму цифр в числе
Console.Clear();
Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine());
int i=0;
while(number>0) 
{
   i = i + number % 10;
   number /= 10;
}
Console.WriteLine("Сумма числа: {0}", i);
return 0;
