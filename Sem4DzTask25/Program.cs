// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int GetResult (int n1, int n2)
{
    int result = 1;
    for (int i = 1; i <= n2; i++)
    {
        result = result*n1;
    }
    return result;
}


int A = GetNumber("Введите число A: ");
int B = GetNumber("Введите число B: ");

System.Console.WriteLine($"Результат:  {GetResult(A,B)}");