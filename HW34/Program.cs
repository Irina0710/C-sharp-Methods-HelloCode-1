// 34. Написать программу замену элементов массива на противоположные
int [] array = new int [6] {8, -3, 16, -6, -1, 0};
for (int i = 0; i<6; i++)
{
    Console.WriteLine(array[i]);
    array[i] = -array[i];
    Console.WriteLine(array[i]);
}