Console.Clear();
Console.Write("Введите цифру дня недели от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1 || n == 2 || n == 3 || n == 4 || n == 5)
Console.WriteLine("Рабочий день");
else if (n == 6 || n == 7)
Console.WriteLine("Выходной");