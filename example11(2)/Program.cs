
int GenerateRandomNumber()
{
    return new Random().Next(100, 1000);
}

 
// 1. Сгенерировать случайное число на отрезке
int randomNumber = GenerateRandomNumber();
 Console.WriteLine("Сгенерировали число в диапазоне [100, 999]: " + randomNumber);
// 2. Найти отдельно сотни, десятки, единицы

int sotni = randomNumber / 100;
int desyatki = randomNumber / 10;
int yedinitsy = randomNumber % 10;
    
// 3. Показать результат
Console.Write("Число: " + sotni + yedinitsy);
