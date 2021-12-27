// Удалить вторую цифру трёхзначного числа
int A = 234;
int Number1 = A/100;
int Number2 = (A/10)%10;
int Number3 = A%10;
int B = (Number1*10) + Number3;
Console.WriteLine (B);
