// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Пример, 6 -> да, 7 -> да, 1 -> нет

Console.Clear();

Console.Write("Введи число от 1 до 7: ");
string value = Console.ReadLine();
int number = int.Parse(value);

if (number > 7) Console.WriteLine("Введи правильную цифру!");
else if (number < 1) Console.Write("Введи правильную цифру!");
else if (number >= 1 & number <= 5) Console.Write($"{number} - будний день");
else if (number >= 6 & number <= 7) Console.Write($"{number} - выходной день");

// else if (number == 1) Console.Write("1 - Понедельник - будний день");
// else if (number == 2) Console.Write("2 - Вторник - будний день");
// else if (number == 3) Console.Write("3 - Среда - будний день");
// else if (number == 4) Console.Write("4 - Четверг - будний день");
// else if (number == 5) Console.Write("5 - Пятница - будний день");
// else if (number == 6) Console.Write("6 - Суббота - выходной день");
// else if (number == 7) Console.Write("7 - Воскресенье - выходной день");