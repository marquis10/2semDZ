Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число: {n}");
int n12 = n / 10;
int n2 = n12 % 10;
Console.WriteLine($"вторая цифра числа: {n2}");