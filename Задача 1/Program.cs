// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
int count = 0;
System.Console.WriteLine("Случайно сгенерированный массив:");
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1, 100);
    System.Console.Write(array[i] + " ");
    
    if (array[i] > 19 && array[i] < 91){
        count++;
    }
} 

System.Console.WriteLine("");
System.Console.WriteLine("Количество элементов массива, которые лежат в отрезке от 20 до 90:");
System.Console.WriteLine(count);
