﻿// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

System.Console.WriteLine("Случайно полученное число от 1 до 100000: ");
var rand = new Random().Next(1, 100000);
System.Console.WriteLine(rand);
string str = rand.ToString();
int[] array = new int[str.Length];
System.Console.WriteLine("Из него получили массив: ");
for(int i = 0; i < str.Length; i++){
    array[i] = int.Parse(str[i].ToString());
    System.Console.Write(str[i] + " ");
}


// // Из условия задачи сказано, что разряды числа имеют значение, хотя, если как я, перевел все в строку, 
// а потом вывел в массив, разрядность и положение чисел в массиве сохраняется, 
// без использования дополнительного кода. Я правильно сделал или, все же, нужно в коде прописать, что разрядность будет присутствовать?