// // 35. Определить, присутствует ли в заданном массиве, некоторое число 
int [] array = new int [10];
for (int i = 0; i< array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.WriteLine(array[i]);
    Console.WriteLine();
}
for (int i = 0; i< array.Length; i++)
{
    //ищем цифру пять
    if (array[i] == 5)
    {
     Console.WriteLine($"Цифра 5 найдена под индексом {i}");
    }
    else
    {
      Console.WriteLine($"Цифра 5 не найдена на этом месте индекса ({i})");  
    }
}