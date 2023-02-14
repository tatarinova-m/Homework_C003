// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 10000 || n > 99999)
{
    Console.WriteLine("Неподходящее число");
}
else
{

    int rev = 0;
    int temp = n;

    while (rev < temp)
    {
        int x = n % 10;
        rev = rev * 10 + x;
        n = n / 10;
    }


    if (rev == temp)
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}