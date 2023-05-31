// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double NumDegree(double num, double deg)  //Метод возведения в степень
{
    double result = Math.Pow(num, deg);
    Console.WriteLine($"А в степени В равно:  {result}");
    return result;
}


Console.WriteLine("Введите число А!");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число В!");
double B = double.Parse(Console.ReadLine());

NumDegree(A, B);