// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

int m = WriteNumber1();
int n = WriteNumber2();

int WriteNumber1()
{
    Console.WriteLine("Enter number 1: ");
    int firstNumber = int.Parse(Console.ReadLine());
    return firstNumber;
}

int WriteNumber2()
{
    Console.WriteLine("Enter number 2: ");
    int secondNUmber = int.Parse(Console.ReadLine());
    return secondNUmber;
}

string NumberRes(int m, int n)
{
    if (m < n + 1) return $"{m}" + NumberRes(m + 1, n);

    else  return String.Empty;
}

Console.WriteLine(NumberRes(m, n));

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SummNumbers(int m, int n)
{
    if (m < n + 1) 
    {
        return n + SummNumbers(m,n-1);
    }
    else return 0;
}
Console.WriteLine($"sum = {SummNumbers(m, n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int FunctionAkkerman(int m,int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

Console.WriteLine(FunctionAkkerman(m, n));