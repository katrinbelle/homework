/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.Write("Введите первое число: ");
string numberstr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberstr1);
Console.Write("Введите второе  число: ");
string numberstr2 = Console.ReadLine();
int number2 = Convert.ToInt32(numberstr2);
Console.Write("Введите третее число: ");
string numberstr3 = Console.ReadLine();
int number3 = Convert.ToInt32(numberstr3);
Console.Write("Максимальное число из трех чисел равно " + " ");
if (number1 > number2 & number1 > number3)  Console.WriteLine(number1); 
else if (number2> number3)  Console.WriteLine(number2);
else  Console.WriteLine(number3);
