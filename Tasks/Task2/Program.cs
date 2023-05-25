//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Input the number");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumberText = Convert.ToString(number);
if (stringNumberText.Length > 2){
  Console.WriteLine("third digit = " + stringNumberText[2]);
}
else {
  Console.WriteLine("no third digit");
}