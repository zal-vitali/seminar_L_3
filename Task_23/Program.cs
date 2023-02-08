// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Получим последовательность кубов числе от 1 до N. Введите число N:");

int numbern = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= numbern; i++)
{
    int i3 = i * i * i;
    Console.Write(i3);

    if (i < numbern) 
    {
        Console.Write(", ");
    }

    else
    {
        Console.WriteLine("");
    }
}