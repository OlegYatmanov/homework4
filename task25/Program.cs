using System;
using static System.Console;
Clear();

int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}

  Write("Введите число A: ");
  int numberA = int.Parse(ReadLine());
  Write("Введите число B: ");
  int numberB = int.Parse(ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  WriteLine("Ответ: " + exponentiation);