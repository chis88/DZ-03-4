﻿Console.WriteLine("Введите одно число");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= N)
{
    if (index % 2 == 0)
    {
        Console.WriteLine(index);
    }
    index = index + 1;
 }
