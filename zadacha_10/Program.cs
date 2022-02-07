// № 10 Показать вторую цифру трёхзначного числа
int numberA = new Random().Next(100, 999);
Console.WriteLine("Дано число   " + numberA);
Console.WriteLine("Вторая цифра   " + ((numberA % 100) / 10));