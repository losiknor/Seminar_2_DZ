// № 14 Найти третью цифру числа или сообщить, что её нет
int numberA = new Random().Next(1, 10000);
Console.WriteLine("Дано число   " + numberA);
int[] arr = numberA.ToString().ToCharArray().Select(x => x - '0').ToArray();
if (arr.Length < 3)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine("Третья цифра   " + arr[2]);