//2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Например 87 -> 8
Console.Clear();

Random rnd = new Random();
int value = rnd.Next(10, 99);

Console.WriteLine($"Сгенерированное число -> {value}");

int firstNum = value / 10;
int secondNum = value % 10;
int maxNum = 0;

if (firstNum > secondNum)
{
    maxNum = secondNum;
}
maxNum = firstNum;
Console.WriteLine($"Максимальная цифра -> {maxNum}");