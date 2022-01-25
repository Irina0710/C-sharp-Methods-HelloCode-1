// 42. Определить сколько чисел больше 0 введено с клавиатуры
int i = 0;
int count = 0;
int Number = 3;
while (i < Number)
{
    Console.WriteLine("Please insert a number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a>0)
    {
        count=count+1;
    }
    i++;
}
Console.WriteLine($"The amount of numbers typed using keyboard higher then 0 equals to {count}");