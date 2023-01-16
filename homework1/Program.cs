/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое число:" + " ");
string numberstr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberstr1);

Console.Write(" Введите второе число:" + " ");
string numberstr2 = Console.ReadLine();
int number2 = Convert.ToInt32(numberstr2);

if (number1 > number2) Console.WriteLine(" Большое число = " + number1 + " " + "меньшее число = " + number2);
else Console.WriteLine("Большое число = " + number2 + " " + "меньшее число = " + number1);