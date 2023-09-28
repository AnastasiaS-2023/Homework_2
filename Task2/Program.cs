// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// {
//      if (n >= 1 && n < 100)
//         Console.WriteLine("Такой цифры нет");
//      else if (n >= 100 && n < 1000)
//         Console.WriteLine($"{n % 10}");
//      else if (n >= 1000)
//         Console.WriteLine($"{n / 10}");
// }

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Length2 = n.ToString().Length;
if (Length2 >= 3) 
{
	while (n > 999)
		n = n / 10;
	int result = n % 10;
	Console.WriteLine(result);
} 
else
	Console.WriteLine("Такой цифры нет");