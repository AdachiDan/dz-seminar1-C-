void FindNumber(int x)
{
int number = x;
if(number > 99)
{
    int digitIndex = 2;
    int digit = number.ToString()[digitIndex] - '0';
    Console.WriteLine("Третья цифра: " + digit);

}
else
{
    Console.WriteLine("Третьей цифры нет");
}

}

Console.WriteLine("Нахождение третьей цифры числа");
Console.WriteLine("Введите число:");

int x;

while (!int.TryParse(Console.ReadLine()!, out x)){
   Console.WriteLine("Неверный ввод");
   Console.WriteLine("Введите число:");
}

FindNumber(x);

