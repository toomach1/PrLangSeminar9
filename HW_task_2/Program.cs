// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int num1 = SetNumber("M");

int num2 = SetNumber("N");

int summ = 0;

if(num1 < num2)
{
    while (num1 <= num2)
    {
    summ = num1+summ;
    num1++;
    }
}
else
{
   while (num2 <= num1)
    {
    summ = num2+summ;
    num2++;
    } 
}

System.Console.WriteLine(summ);



int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}