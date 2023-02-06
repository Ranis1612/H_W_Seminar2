// Задача 15: Напишите программу принимающую на вход число 
// обозначающую день недели и проверяет является ли этот день выходным 
// 7 - да  5 - нет  6 - да
Console.Clear();
Console.Write("Введите номер дня недели:  ");
int daynumber = int.Parse(Console.ReadLine()!);
if(daynumber == 6 || daynumber ==7)
{
  Console.Write("Этот день выходной");
}
else if(daynumber < 1 || 7 < daynumber)
{
  Console.Write("Это не день недели");
}
else
{
  Console.Write("Этот день не выходной");
}

