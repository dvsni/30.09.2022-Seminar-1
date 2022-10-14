// Напишите программу, которая 
// задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите размерность массива:"); 
int number = Convert.ToInt32(Console.ReadLine()); 
int[] fillarray = new int[number]; 
 
int[] FillArray(int[] array, int num) 
{ 
     
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = new Random().Next(1, 41); 
    } 
    return array; 
} 
void PrintArray(int[] array2) 
{ 
   Console.Write($"[");    
   for (int i = 0; i < array2.Length; i++) 
    { 
        Console.Write($"{array2[i]}"); 
    if (i < array2.Length - 1) 
 
        Console.Write(", "); 
} 
Console.Write($"]"); 
} 
 
int [] myArray = FillArray(fillarray, number); 
PrintArray(myArray);