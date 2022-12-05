Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= -100 || n >= 100)
{
    while (n < -1000 || n > 1000)
    {
        n = n / 10;
    }
    n = n % 10;
    Console.WriteLine($"Третья цифра числа = {n}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}