// Задача 64:
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumberFromUser(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());

}

void NatureNumbersRevert(int num)
{
    if (num == 0) return;
    if (num == 1) Console.Write($"{num}");
    else Console.Write($"{num}, ");
    NatureNumbersRevert(num - 1);
}

Console.Clear();
string title = "Вывод натуральных чисел в промежутке от N до 1.\n"
             + "-----------------------------------------------";
Console.WriteLine(title);

int number = GetNumberFromUser("Введите число N: ");

Console.Write($"N = {number} -> ");
NatureNumbersRevert(number);
