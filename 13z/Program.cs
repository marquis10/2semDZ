Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= -100 || n >= 100)
{
    if (n <= -1000 || n >= 1000)
    {
        if (n <= -10000 || n >= 10000)
        {
            if (n <= -100000 || n >= 100000)
            {
                if (n <= -1000000 || n >= 1000000)
                {
                    if (n <= -10000000 || n >= 10000000)
                    {
                        if (n <= -1000000000 || n >= 1000000000)
                        {
                            n = n / 1000000;
                            Console.WriteLine($"Третья цифра числа: {n % 10}");                                             
                        }
                        else
                        {
                            n = n / 100000;
                            Console.WriteLine($"Третья цифра числа: {n % 10}");
                        }
                    }
                    else
                    {
                        n = n / 10000;
                        Console.WriteLine($"Третья цифра числа: {n % 10}");
                    }
                }
                else
                {
                    n = n / 1000;
                    Console.WriteLine($"Третья цифра числа: {n % 10}");
                }
            }
            else
            {
                n = n / 100;
                Console.WriteLine($"Третья цифра числа: {n % 10}");
            }
        }
        else
        {
            n = n / 10;
            Console.WriteLine($"Третья цифра числа: {n % 10}");
        }
    }                 
    else
    {
        Console.WriteLine($"Третья цифра числа: {n % 10}");
    }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}