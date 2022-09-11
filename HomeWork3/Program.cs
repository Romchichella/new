// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
//int n = Convert.ToInt32(Console.ReadLine());

string? numberFive = Console.ReadLine();
Console.WriteLine();

//int[] array = new int[n];
//for (int i = 0; i<5; i++)
//{

if (numberFive[0] == numberFive[4] && numberFive[1] == numberFive[3])
{
    Console.WriteLine("Число является палиндромом");
}
else
    Console.WriteLine("Число не является палиндромом");
Console.WriteLine();
//}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Необходимо найти расстояние между двумя точками в трехмерном пространстве: ");
Console.WriteLine();
Console.Write("Ввести координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Ввести координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Ввести координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Ввести координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Ввести координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Ввести координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками : {Math.Round(d, 4)}");
Console.WriteLine();


// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N и вы получите список чисел от 1 до N, возведенных в 3 степень: ");

int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Вы выбрали N =" + numberN);
Console.WriteLine();
for (int numberA = 1; numberA <= numberN; numberA++)
{
    Console.WriteLine(numberA * numberA * numberA);
}
