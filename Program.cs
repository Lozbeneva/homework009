/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */


void PrintNaturalNumbers(int firstNumber, int secondNumber)
{
    if (secondNumber >= firstNumber)
    {

        Console.Write(secondNumber + "  ");
        PrintNaturalNumbers(firstNumber, secondNumber - 1);

    }

}

Console.WriteLine("Введите первое число М -> ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число N -> ");
int n = int.Parse(Console.ReadLine());

if (m > n)
{
    PrintNaturalNumbers(n, m);
}
else PrintNaturalNumbers(m, n); 

//*******************************************************************************
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

int SummNaturalNumbers(int firstNumber, int secondNumber)
{
    int res = secondNumber;
    if (secondNumber > firstNumber)
    {
        res += SummNaturalNumbers(firstNumber, secondNumber - 1);
    }

    return res;
}

Console.WriteLine("Введите первое число М -> ");
int m2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число N -> ");
int n2 = int.Parse(Console.ReadLine());

int summa;
if (m2 > n2)
{
   summa = SummNaturalNumbers(n2, m2);
}
else
{ 
    summa = SummNaturalNumbers(m2, n2);
}

Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел от {n2} до {m2} равна {summa}");


//*******************************************************************************
/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9 */

int Akerman(int m3, int n3)
{
    if (m3 == 0)
    {
        return n3 + 1;
    }
    if (n3 == 0)
    {
        return Akerman(m3 - 1, 1);
    }
    return Akerman(m3 - 1, Akerman(m3, n3 - 1));

}


Console.WriteLine("Введите первое число М -> ");
int m3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число N -> ");
int n3 = int.Parse(Console.ReadLine());

if (m3 < 0 || n3 < 0)
{
    Console.WriteLine("Одно или оба числа отрицательные");
    return;
}
Console.WriteLine($"Результат -> {Akerman(m3, n3)}");