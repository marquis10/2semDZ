﻿//Задача из темы циклов
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 0;
while (n != 0)
{    
    if (n > max1)
    {
        max2 = max1;
        max1 = n;
        n = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine($"второе максимальное = {max2}");