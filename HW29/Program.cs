//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void FillArray(int[] sequel)  //Метод заполнение массива 
{
    int size = sequel.Length;
    for (int i = 0; i < size; i++) sequel[i] = new Random().Next(100);   

}

void PrintArray(int[] sequel) //Метод распечатки массива
{  
    int size = sequel.Length;
    for (int i = 0; i < size; i++)  Console.WriteLine(sequel[i]);

}

int[] numm = new int[8];   //Объвление массива 

FillArray(numm);
PrintArray(numm);


