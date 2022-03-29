// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Пример, 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
string value = Console.ReadLine();

int Number = int.Parse(value);

if (Number < 100)
{
    Console.Write("третьей цифры нет!");
    return;
}
for ( ; Number > 1000; Number /= 10)
{
    
}
int thirdNum = Number % 10;
Console.WriteLine(thirdNum);