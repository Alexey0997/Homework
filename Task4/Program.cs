// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите первое целое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int numberС = int.Parse(Console.ReadLine());
int max = numberA;
if(numberB > max)
{
    max = numberB;
}
if(numberС > max)
{
    max = numberС;
}
Console.WriteLine($"Максимальное число {max}.");
