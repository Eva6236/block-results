﻿//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Console.WriteLine("Введите массив строк через пробел");
string[] array1;
string stroka = Console.ReadLine()!;
array1 = stroka.Split(' ');
var result = new string[array1 .Length];
string[] array2 = new string[array1.Length];
SecondArrayWithIF(array1, array2);
PrintArray(array2);






void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}