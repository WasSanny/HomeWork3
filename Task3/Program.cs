// Программа, которая на вход принимает число (N) и выдает
// таблицу кубов чисел от 1 до (N): _Задача 23_

Console.Write("Введите число: ");

int.TryParse(Console.ReadLine(), out int N);
int index = 1;

while (index <= N)
{
  Console.Write(Math.Pow((index), 3) + " ");
  index++;
}