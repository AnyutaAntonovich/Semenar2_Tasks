//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Input the three digit number");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine("The second digit of this number = "+stringNumber[1]);