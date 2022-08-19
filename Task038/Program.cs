// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[12]; // 12 => array = [0,0,0,...,0]

double diff = 0; // разность между максимальным и минимальным элементом массива
double max = 0; // максимальное число
double min = 99; // минимальное число

int index = 0; // точка старта цикла
int length = array.Length; // количество элементов: array.Length = 12
for(index = 0; index < array.Length; index++)
// i - index
//while (index < length) // i<array.Length
{
    array[index] = new Random().Next(1,10); //[0;99)
    Console.WriteLine(array[index]);
    if (array[index] > max) max = array[index]; //
    if (array[index] < min) min = array[index];//
 
    
     
}
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
diff =  max - min;
Console.WriteLine($"Разность мехду максимальным и минимальным числом составляет: {diff}");


