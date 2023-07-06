using System;
using static System.Console;
Clear();

Write("Введите число: ");
int numberN = int.Parse(ReadLine());
int SumNumber(int numberN){
    
int counter = Convert.ToString(numberN).Length;
int advance = 0;
int result = 0;

for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
}

int sumNumber = SumNumber(numberN);
WriteLine("Сумма цифр: " + sumNumber);