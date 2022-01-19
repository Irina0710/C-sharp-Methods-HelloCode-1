// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int [] array = new int [10];
int count = 0;
for (int i = 0; i< array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.WriteLine(array[i]);
}
Console.WriteLine();
for (int i = 0; i< array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = count + 1;
        Console.WriteLine ($"Число с индексом {i} четное");
    }
    else
    {
       Console.WriteLine ($"Число с индексом {i} нечетное"); 
    }
}
 Console.WriteLine ($"Всего четных чисел {count}"); 
 Console.WriteLine ($"Всего нечетных чисел {array.Length - count}"); 