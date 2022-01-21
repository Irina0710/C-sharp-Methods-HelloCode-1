// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// парой считается 1 и последняя цифра, вторая и предпоседняя и д
int [] Array = {2,4,6,8,10,12,14,16};
for (int i = 0; i< Array.Length; i++)
{
    int multiplication = Array[i] * Array[(Array.Length - i - 1)];
    Console.WriteLine(multiplication);
if (i >= (Array.Length / 2 ) - 1) break;
}
