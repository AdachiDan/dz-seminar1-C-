void FindDigit(int x)
   {
      int digit = x;
      int y = 10;
      while (digit > 0)
            {
               if (digit < y) // do 9
                  {
                     Console.WriteLine("Второй цифры нет");
                     break;
                  }
               else
                  {
                     y = y * 10; // do 99
                     if (digit < y)
                        {
                           int firstDigit = digit / 10;
                           Console.WriteLine("Без второй цифры: " + firstDigit);
                           break;
                        }
                      else
                        {
                           y = y * 10; // do 999
                          if (digit < y)
                             {
                               int firstDigit = digit / 100;
                               int thirdDigit = digit % 10;
                               Console.Write("Без второй цифры: " + firstDigit + thirdDigit);
                               break;
                             }
                          else
                             {
                                y = y * 10; // do 9999
                                if (digit < y)
                                   {
                                      int firstDigit = digit / 1000;
                                      int thirdDigit = (digit / 10) % 10;
                                      int fourDigit = digit % 10;
                                      Console.Write("Без второй цифры: " + firstDigit + thirdDigit + fourDigit);
                                      break;
                                   } 
                                else
                                   {
                                      y = y * 10; // do 99999
                                      if (digit < y)
                                         {
                                            int firstDigit = digit / 10000;
                                            int thirdDigit = (digit / 100) % 10;
                                            int fourDigit = (digit / 10) % 10;
                                            int fiveDigit = digit % 10;
                                            Console.Write("Без второй цифры: " + firstDigit + thirdDigit + fourDigit + fiveDigit);
                                            break;
                                         }
                                       else
                                       {
                                           y = y * 10; // do 999999
                                           if (digit < y)
                                           {
                                              int firstDigit = digit / 100000;
                                              int thirdDigit = (digit / 1000) % 10;
                                              int fourDigit = (digit / 100) % 10;
                                              int fiveDigit = (digit / 10) % 10;
                                              int sixDigit = digit % 10;
                                              Console.Write("Без второй цифры: " + firstDigit + thirdDigit + fourDigit + fiveDigit + sixDigit);
                                              break;
                                           }

                                       }  
                                   }   
                            }
                        }
                   }
            }
    }

Console.WriteLine("Нахождение числа без второй цифры");
Console.WriteLine("Введите число:");

int x;

while (!int.TryParse(Console.ReadLine()!, out x))
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите число:");
}

FindDigit(x);

