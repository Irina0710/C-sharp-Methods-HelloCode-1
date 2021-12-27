//lано число из отрезка [10, 99]. Показать наибольшую цифру числа
int A = 74;
int first = A%10;
int last = (A/10);
if (first > last) 
{
 Console.Write("Большая цифра равна ");
Console.WriteLine(first);
}
else
{
Console.Write("Большая цифра равна ");
Console.WriteLine(last);
} 