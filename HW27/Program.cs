// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

void SumDig(int num) //Метод подсчета и вывода суммы цифр в числе
{   
    int temp = 0;
    while(num != 0)
    {
        temp = temp + num % 10; //Суммирование цифр с конца
        num = num / 10;        //Перебор цифр числа с конца
        //return temp;
    }  
  Console.WriteLine($"{temp}"); 
} 

Console.WriteLine("Введите число!");
int namber = int.Parse(Console.ReadLine());
SumDig(namber);
