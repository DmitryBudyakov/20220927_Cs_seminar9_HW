// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumberFromUser(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return (n + 1);
    else
        if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else
        // if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    // else return 0;
}

Console.Clear();
string title = "Вычисление функции Аккермана A(m,n)\n"
            + "-----------------------------------";
Console.WriteLine(title);

int numberM = GetNumberFromUser("Введите число m: ");
int numberN = GetNumberFromUser("Введите число n: ");


if (numberM >= 0 & numberN >= 0)
{
    int result = AkkermanFunction(numberM, numberN);
    Console.WriteLine($"A({numberM},{numberN}) = {result}");
}
else Console.WriteLine("Числа m и n должны быть целыми, неотрицательными. Повторите ввод.");
