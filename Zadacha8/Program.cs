/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, */

Console.Clear();

Console.WriteLine("Введите число ");

int N = Convert.ToInt32(Console.ReadLine());

int sum = 1;

Console.WriteLine("Чётные числа в заданном диапазоне: ");

while (sum < N)
{
    if (sum % 2 == 0)
    {
        Console.WriteLine(sum + "");
    }
    sum++;
}