
int GenerateRandomNumber()
{
    return new Random().Next(10, 100);
}

int GetMaxDigitForTwoDigitsNumber(int randomNumber)
{
    int desyatki = randomNumber / 10;
    int yedinitsy = randomNumber % 10;
   
    int max = desyatki;
    if (desyatki < yedinitsy)
        max = yedinitsy;

        return max;
}

// 1. Сгенерировать случайное число на отрезке
int randomNumber = GenerateRandomNumber();
 Console.WriteLine("Сгенерировали число в диапазоне [10, 99]: " + randomNumber);
// 2. Найти наибольшую цифру числа
int max = GetMaxDigitForTwoDigitsNumber(randomNumber);
// 3. Показать результат
Console.WriteLine("Наибольшая цифра числа: " + max);
