//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
{
    Console.WriteLine("Введите значение M:");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int n = Convert.ToInt32(Console.ReadLine());

    int result = SumOfNaturalNumbers(m, n);

    Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {result}");
}

int SumOfNaturalNumbers(int m, int n)
{

    if (m > n)// Пролверим, чтобы убедиться, что m не больше n
    {
        int temp = m;
        m = n;
        n = temp;
    }

    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum += i;
    }

    return sum;
}