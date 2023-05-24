//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Input the number");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 5) Console.WriteLine("No");
else if (number >= 6 && number <= 7) Console.WriteLine("Yes");
else Console.WriteLine("There is no such day of the week");