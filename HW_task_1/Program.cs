// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.



int n = SetNumber("n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}