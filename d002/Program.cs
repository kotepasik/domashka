// 1.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.Write("Введи трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
Console.WriteLine("вторая цифра этого числа -> " + stringNumber[1]);


// 2.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(Number);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}
*/

//  3. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

/*
Console.Write("Введи цифру, обозначающую день недели: ");
int dayN = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayN) {
  if (dayN == 6 || dayN == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (dayN < 1 || dayN > 7) {
    Console.WriteLine("в неделе 7 дней)");
  }
  else Console.WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(dayN);
*/