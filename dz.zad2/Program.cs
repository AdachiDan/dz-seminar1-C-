Console.WriteLine("Поиск наибольшего числа из двух");
Console.WriteLine("Введите первое число:");
string inputString = Console.ReadLine()!;
int x = int.Parse(inputString);
Console.Clear();
Console.WriteLine("Введите второе число:");
string inputString2 = Console.ReadLine()!;
int x2 = int.Parse(inputString2);
Console.Clear();

if (x > x2)
{
    Console.WriteLine("Максимальное число " + x);
}
else
{
    Console.WriteLine("Максимальное число " + x2);
}
