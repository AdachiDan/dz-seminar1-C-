Console.WriteLine("Программа вычисления квадрата числа");
Console.WriteLine("Введите число, затем нажмите ENTER");
// 1. Ввод числа
string inputString = Console.ReadLine()!;
int input = int.Parse(inputString);
// 2. Вычисление квадрата числа
int result = input * input;
// 3. Вывод результата на консоль
Console.WriteLine("Квадрат числа: " + result);