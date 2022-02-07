// № 12 Удалить вторую цифру трёхзначного числа
int numberA = new Random().Next(100, 999);
Console.WriteLine("Дано число   " + numberA);
Console.WriteLine("Число без второй цифры   " + (numberA / 100) + "_" + (numberA%10));