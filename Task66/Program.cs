// Задача 66:
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumberFromUser(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNatureNumbers(int numM, int numN)
{
    if (numM <= numN)
    {
        if (numN == numM) return numM;
        numN += SumOfNatureNumbers(numM, numN - 1);

        return numN;
    }

    else
    {
        numM += SumOfNatureNumbers(numM - 1, numN);

        return numM;
    }

}


Console.Clear();
string title = "Сумма натуральных элементов от M до N\n"
            + "-------------------------------------";
Console.WriteLine(title);

int numberM = GetNumberFromUser("Введите число M: ");
int numberN = GetNumberFromUser("Введите число N: ");

if (numberM > 0 && numberN > 0)
{
    int result = SumOfNatureNumbers(numberM, numberN);
    Console.WriteLine($"Сумма от M до N = {result}");
}
else Console.WriteLine("Числа M и N должны быть натуральными. Повторите ввод.");
