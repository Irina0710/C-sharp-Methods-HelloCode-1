// 47. Написать программу копирования массива
int[] array = new int[10] {2,4,3,5,6,5,4,4,3,6};
int[] copy = new int[10];

for (int i=0; i <array.Length; i++)
{
    copy[i] = array[i];
    Console.WriteLine (copy[i]);
}
