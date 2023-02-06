// На столе лежат n монеток. Некоторые из них лежат вверх решкой, 
// а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть, 
// чтобы все монетки были повернуты вверх одной и той же стороной.
Console.Clear();
Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine()!);
int [] array1 = new int[n];
for(int i = 0; i < n; i++)
{
  array1[i] = new Random().Next(0, 2);
}
Console.Write("Массив:  ");
for(int i = 0; i < n; i++)
{
  Console.Write($"{array1[i]}");
}
//
int r = 0, g = 0;
for(int i = 0; i < n; i++)
{
  if(array1[i] == 1)
  {
    r++;
  }
  else
  {
    g++;
  }
}
Console.WriteLine();
if(r < g)
{
  Console.Write($"{g}");
}
else
{  
  Console.Write($"{r}");
};