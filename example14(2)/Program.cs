bool multiplicity(int x)
{
    return x % 7 == 0 && x % 23 == 0;
}

void result(int x)
{
    if (multiplicity(x))
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
