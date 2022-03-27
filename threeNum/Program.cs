//напиши последнюю цифру из трех чисел, например
//456 - 6, 789 - 9 и т.д.

Console.Clear();

Console.Write("Введите число: ");
string value = Console.ReadLine();

int Number = int.Parse(value);

int lastNum = Number % 10;

Console.WriteLine(lastNum);
