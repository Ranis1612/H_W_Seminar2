// Задача 10: Напишите программу, которая на вход принимает трёхзначное число
// и на выходе показывает вторую цифру этого числа  
//  456 - 6   782 - 8    918 - 1
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if(num >100 && num < 1000)
{
 int num1 = num / 10;
int num2 = num1 % 10;
Console.Write(num2);
}
else
{
 Console.Write("Сказано трёхзначное счетовод хренов!!! "); 
}
