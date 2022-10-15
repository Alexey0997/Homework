// Задача 8: Напишите программу, которая на вход принимает число N, 
// а на выходе показывает все четные числа от 1 до N.
Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());
int count = 2; // Поскольку это первое четное число после 1.
Console.WriteLine($"В диапазоне от {1} до {number} имеются следующие четные числа: ");
while(count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
}