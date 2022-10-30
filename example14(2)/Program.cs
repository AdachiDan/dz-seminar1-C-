void result(int x)
{
int ost1 = x % 7;
int ost2 = x % 23;
    if (ost1 == 0 && ost2 == 0)
    {
        Console.WriteLine("Число " + x + " кратно 23 и 7");
    }
    else
    {
        Console.WriteLine("Число " + x + " некратно 23 и 7");
    }

}

Console.WriteLine("Проверка: кратно ли число 7 и 23 одновременно");
Console.WriteLine("Введите число:");

int x;

while (!int.TryParse(Console.ReadLine()!, out x)){
   Console.WriteLine("Неверный ввод");
   Console.WriteLine("Введите число:");
}

result(x);
