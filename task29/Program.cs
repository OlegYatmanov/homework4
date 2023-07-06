using System;
using static System.Console;
Clear();

int[] numbers = new int[8];
Write("[");

for (int i = 0; i < numbers.Length; i++)
{
  numbers[i] = new Random().Next(0, 20);
  Write(" " + Array(i) + " ");
}
Write("]");

int Array(int a)
{
  return numbers[a];
}