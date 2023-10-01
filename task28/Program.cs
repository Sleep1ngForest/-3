// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int n=8;
int[] mass= new int[n];
for (int i=0; i<n;i++){
    mass[i]= new Random().Next(0,2);
}

for (int i=0; i<n;i++){
    System.Console.Write($"{mass[i]},");
}

20:47
int writeMult(int num){
    int mult = 1;
    for(int i=1; i<=num;i++){
        mult*=i;
    }
    return mult;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(writeMult(number));