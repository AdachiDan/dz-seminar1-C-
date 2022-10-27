Console.WriteLine("Проверка на четность");
Console.WriteLine("Введите число:");
string number = Console.ReadLine()!;
int x = int.Parse(number);
Console.Clear();
if (x % 2 == 0)
{
    Console.WriteLine("Число " + x + " четное");
}
else
{
    Console.WriteLine("Число " + x + " нечетное");
}
