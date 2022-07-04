/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите пятизначное число для проверки на полиндромность: ");
int number = Convert.ToInt32(Console.ReadLine());
int dig5 = number % 10;
int dig4 = number / 10 % 10;
int dig3 = number / 100 % 10;
int dig2 = number / 1000 % 10;
int dig1 = number / 10000;

bool Polyndrom (int num)
{
    if (dig5 == dig1 && dig4 == dig2)
        return true;
    else
        return false;
}
bool result = Polyndrom (number);
Console.Write($"Число {number} является полиндромом. {result}");