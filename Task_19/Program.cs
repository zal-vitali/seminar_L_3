//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Проверим, является ли введённое пятизначное число палиндромом? Введите число:");

int number = int.Parse(Console.ReadLine()!);
string result = "";

if ((number < 10000) || (number > 99999)) 
{
    result = " не пятизначное";
}

else
{
    int n1 = (number / 10000);
    int n2 = (number / 1000) % 10;
    int n4 = (number / 10) % 10;
    int n5 = (number % 10);

    if ((n1 == n5) && (n2 == n4))
    {
        result = " является палиндромом";
    }

    else
    {
        result = " не является палиндромом";
    }

}

Console.WriteLine($"Число {number}{result}");