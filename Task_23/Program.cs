/* Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите число для вывода таблицы кубов: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int kube = 0;
Console.WriteLine("       Число        Куб");
while (count <= number)
{
    kube = count*count*count;
    Console.WriteLine($"{count, 10}  {kube, 10}");
    count++;
}