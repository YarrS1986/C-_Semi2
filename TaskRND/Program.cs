Random rnd = new Random();

int value = rnd.Next(5, 10);
while (value != 9)
{
    Console.WriteLine($"Случайное число = {value}");
    value = rnd.Next(5, 10);
}





