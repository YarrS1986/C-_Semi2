//4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// напрмер 14 -> нет, 46 -> нет, 161 -> да

Console.Clear();

Console.Write("Введи число = ");
string Number = Console.ReadLine();
int num = int.Parse(Number);
int result1 = num % 7;
int result2 = num % 23;

if (result1 == 0 && result2 == 0) Console.Write($"{num} -> да");
else Console.Write($"{num} -> нет");