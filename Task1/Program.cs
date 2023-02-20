// Программа, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int.TryParse(Console.ReadLine(), out int first);
int length = first.ToString().Length;

if (length == 5)
{
  int a = first % 100;
  int b = first / 1000;
  int c = first / 100 % 10;
  
  if (b.ToString()[0] == a.ToString()[1] && b.ToString()[1] == a.ToString()[0])
  {
    Console.WriteLine($"Введенное Вами число {first} является - палиндромом: {b} {c} {a}");
  }
  else
  {
    Console.WriteLine($"Вы ввели число {first}, оно НЕ является палиндромом: {b} {c} {a}");
  }
}
else
{
  Console.Write($"Число {first} - НЕ является пятизначным, повторите ввод числа!");
}