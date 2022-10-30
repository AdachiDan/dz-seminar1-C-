
int GenerateRandomNumber()
{
    return new Random().Next(100, 1000);
}


 int GetSecondNumber(int randomNumber)
 {
    Console.WriteLine("Сгенерировали число в диапазоне [100, 999]: " + randomNumber);
    int sotni = randomNumber / 100;
    int yedinitsy = randomNumber % 10;
    return sotni*10 + yedinitsy;
 }

int randomNumber = GenerateRandomNumber();
 Console.Write("Число: " + GetSecondNumber(randomNumber));
