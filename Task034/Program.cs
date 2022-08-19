// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[8]; // 8 => array = [0,0,0,...,0]

int countEvenNum = 0; // количество четных чисел


int i = 0; // точка старта цикла
int length = array.Length; // количество элементов: array.Length = 8
// for(int index = 0; index < array.Length; index++)
// i - index
while (i < length) // i<array.Length
{
    array[i] = new Random().Next(100,1000); //[100,999]
    
    if (array[i] %2 == 0) //определяем четные числа
    {
        countEvenNum = countEvenNum + 1; //cчитаем четные числа
    }
        else
        {
        countEvenNum = countEvenNum;
        }
        i++; 
    }
     


Console.WriteLine($"[{String.Join("; ", array)}] => {countEvenNum}");

