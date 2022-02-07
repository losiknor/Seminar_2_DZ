// № 16 Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int numberA = new Random().Next(1, 7);
Console.WriteLine("Дано число   " + numberA);
if ((numberA == 6)||(numberA == 7) )
Console.WriteLine("Это выходной");
else
Console.WriteLine("Это не выходной");