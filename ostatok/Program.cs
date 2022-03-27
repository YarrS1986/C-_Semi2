//3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();

Console.Write("Введи первое число = ");
string Number1 = Console.ReadLine();
int num1 = int.Parse(Number1);
Console.Write("Введи второе число = ");
string Number2 = Console.ReadLine();
int num2 = int.Parse(Number2);

int output = num1 % num2;
if (output == 0)
{
    Console.Write("остатка нет");
}
Console.Write($"Остаток = {output}");


//int firstNum = value / 10;
//int secondNum = value % 10;
//int maxNum = 0;

//if (firstNum > secondNum)
//{
  //  maxNum = secondNum;
//}
//maxNum = firstNum;
//Console.WriteLine($"Максимальная цифра -> {maxNum}");