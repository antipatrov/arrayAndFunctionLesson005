// Задача 36: Задайте одномерный массив, заполненный случайными 
//числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[8]; // 8 => array = [0,0,0,...,0]

int sumOddNum = 0; // сумма нечетных чисел


int i = 0; // точка старта цикла
int length = array.Length; // количество элементов: array.Length = 8
//for(i = 0; i < array.Length; i++)

while (i < length) // i<array.Length
{
    array[i] = new Random().Next(0,10); //[0,99]
    Console.WriteLine(array[i]);
    
    if (i %2 == 1) //определяем индекс нечетных чисел
    {
        sumOddNum  = sumOddNum + array[i];
        } 
        i++; 
    }
     


Console.WriteLine("Сумма нечетных чисел равна: " + sumOddNum);

