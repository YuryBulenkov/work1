// Напишите программу, которая на вход принимает два числа и выдает,
// какое число больше, а какое меньше.
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = a;
if(b > a) max = b;
{
    Console.WriteLine("Максимальное число: " + max);
}
