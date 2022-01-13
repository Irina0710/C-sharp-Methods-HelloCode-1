// 27. Определить количество цифр в числе
Console.Clear();
Console.Write("Введите число: ");
int chislo=int.Parse(Console.ReadLine());
int i=0;
while(chislo>0) 
{
   i++;
   chislo/=10;
}
Console.WriteLine("Количество цифр: {0}", i);
return 0;

