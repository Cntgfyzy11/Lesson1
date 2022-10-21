// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int index = 1;
while(index<=number)
{
    if(number % 2 == 0 || index / 2 == 1)
    {
        Console.WriteLine(index + 1);
    }
    Console.WriteLine(index++);
}