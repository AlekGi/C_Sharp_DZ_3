﻿// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
int count = 0;
System.Console.WriteLine("Случайно сгенерированный массив:");
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(-100, 100);
    System.Console.Write(array[i] + " ");
    
    if (array[i] % 2 == 0){
        count++;
    }
} 

System.Console.WriteLine("");
System.Console.WriteLine("Количество чётных чисел в массиве:");
System.Console.WriteLine(count);
