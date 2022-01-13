// Показать таблицу квадратов чисел от 1 до N 
int n = new Random().Next(1, 11);
int i = 1;
while (i < n)
{
    int squarenumbers = i * i;
    Console.WriteLine("Квадрат числа " + i + " = " + squarenumbers);
    i++;
}

