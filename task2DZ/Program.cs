// Задача №2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// Пример: 
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3


// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)  
// {
//     System.Console.WriteLine("Большее число:" + a + ", меньшее число:" + b);
// }
// else 
// {
//     System.Console.WriteLine($"Большее число: (a), меньшее число: (b)");
// }

Console.WriteLine("Пожалуйста введите 2 числа,");
Console.WriteLine("чтобы узнать какое большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " большее");
    Console.Write("Число " + num2 + " меньшее");
}
else if (num1 == num2)
{
    Console.WriteLine("Число " + num1 + " равно числу " + num2);
}
else
{
    Console.WriteLine("Число " + num2 + " большее");
    Console.Write("Число " + num1 + " меньшее");
}