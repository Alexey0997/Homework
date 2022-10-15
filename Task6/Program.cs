// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли на два без остатка).
Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое число: ");
int number = int.Parse(Console.ReadLine());
int result = number%2;
if(result == 0)
{
    Console.WriteLine($"Число {number} является четным, т.к. оно делится на {2} без остатка.");
}
else
{
    Console.WriteLine($"Число {number} НЕ является четным, т.к. оно не делится на {2} без остатка.");
}