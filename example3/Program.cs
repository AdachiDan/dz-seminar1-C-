// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number: ");
int number_1 = int.Parse(Console.ReadLine()!);

if ((0<number_1)&&(number_1<8)){
    if (number_1 == 1) Console.WriteLine("Monday");
    if (number_1 == 2) Console.WriteLine("Tuesday");
    if (number_1 == 3) Console.WriteLine("Wensday");
    if (number_1 == 4) Console.WriteLine("Thursday");
    if (number_1 == 5) Console.WriteLine("Friday");
    if (number_1 == 6) Console.WriteLine("Saturday");
    if (number_1 == 7) Console.WriteLine("Sunday");
}
else {
    Console.WriteLine("Please, imput from 1 to 7");
}
