Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (99 < a && a <= 999)
{
    Console.Write("Вторая цифра числа: ");
    Console.WriteLine((a / 10) % 10);
}
else
{
    Console.WriteLine("Некорректное число!");
}
