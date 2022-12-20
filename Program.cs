// 1 Задача
Console.Write("Введите число А:");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B:");
int number2 = int.Parse(Console.ReadLine()!);
if (number1>number2)
{
    Console.WriteLine("A больше B");
}
else
{
    if (number1<number2)
    {
        Console.WriteLine("B больше A");
    }
    else
    {
        Console.WriteLine("A равно B");
    }

}


// 2 задача
Console.Write("Введите первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число:");
int num3 = int.Parse(Console.ReadLine()!);
int max = num1;
if (max<num2)
{
    max = num2;
}
if (max<num3)
{
    max = num3;
}
Console.WriteLine($"максимальное число = {max}");

// 3 задача 
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine()!);
if (number%2 ==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

// 4 задача
Console.Write("Введите N:");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (1 <= N)
{
    if (i%2 ==0)
    {
        Console.WriteLine($"{i}");
    }
    i++;
}
