/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
            isCorrect = true;
        else
            Console.WriteLine("Вы ввели не число!\n");
    }

    return result;
}

int FunctionAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAckerman(m - 1, 1);
    else return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}

int m = GetNumber("Введите неотрицательное число m");
int n = GetNumber("Введите неотрицательное число n");
Console.WriteLine($"Функции Аккермана А({m},{n})= {FunctionAckerman(m, n)}");

