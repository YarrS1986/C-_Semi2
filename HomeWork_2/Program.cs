// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Пример, 456 -> 46, 782 -> 72, 918 -> 98

Console.Clear();

Random rnd = new Random();
int Number=rnd.Next(100, 999);

Console.WriteLine($"Сгенерированное число -> {Number}");

int firstNum = Number / 100;
int lastNum = Number % 10;

Console.WriteLine($"Число без 2го символа -> {firstNum}{lastNum}");
