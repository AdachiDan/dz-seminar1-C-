// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 == number2*number2)
{
    Console.WriteLine("Да");
}
else {
    if (number2 == number1*number1) {
        Console.WriteLine("Да");
    }
    else {
        Console.WriteLine("Нет");
    }
}
