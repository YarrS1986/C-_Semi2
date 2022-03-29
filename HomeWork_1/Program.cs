// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Пример, 456 -> 5, 782 -> 8, 918 -> 1
Console.Clear();

Console.Write("Введите число: ");
string value = Console.ReadLine();

int Number = int.Parse(value);

int lastNum = Number / 10;
int midNum = lastNum % 10;

Console.WriteLine(midNum);