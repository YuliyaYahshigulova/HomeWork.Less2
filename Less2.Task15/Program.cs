Console.WriteLine("Введите число от 1 до 7 включительно: ");
int d = Convert.ToInt32(Console.ReadLine());
int x = 7;

if (d > x)
{
    Console.WriteLine("Ошибка!");
}
else
{
    if (x - 1 <= d && d <= x)
    {
        Console.WriteLine("Выходной день!");
    }
    else
    {
        Console.WriteLine("Рабочий день!");
    }
}