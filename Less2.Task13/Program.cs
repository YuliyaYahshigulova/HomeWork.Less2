Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x <= 99)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    while (x >= 999)
    {
        x = x / 10;
    }
    Console.Write("Третья цифра числа: ");
    Console.WriteLine(x % 10);
}