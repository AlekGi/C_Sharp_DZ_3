// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] array = [1.1, 0.3, 3.2, 1.5, 5.8, 4.2, 2.2, 9.5, 7.6, 6.2];
double min = array[0];
double max = array[0];
double result = 0;
System.Console.WriteLine("Наш массив: [1.1, 0.3, 3.2, 1.5, 5.8, 4.2, 2.2, 9.5, 7.6, 6.2]");

for (int i = 0; i < array.Length; i++){
    if (max < array[i]){
        max = array[i];
    }
    if (min > array[i]){
        min = array[i];
    }
}
result = max - min;

System.Console.WriteLine("_________________");
System.Console.WriteLine($"Максимальное значение массива: {max}");
System.Console.WriteLine($"Минимальное значение массива:  {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");





