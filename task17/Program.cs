// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координату x: ");
int x =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в первой четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится во второй четверти");
}

else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в третьей четверти");
}

else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в четвертой четверти");
}

else
{
     System.Console.WriteLine("Точка не может содержать координату 0");
}