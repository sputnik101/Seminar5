// // Задача 31:
// // Задайте массив из 12 элементов,
// // заполненный случайными 
// // числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// // сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int [12];
// int i = 0;
// int posNum = 0;
// int negNum = 0;

// while (i<12)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write($" {array [i]} ");
//     i=i+1;
// }

// i=0;

// while (i<12)
// {
  
//   if (array[i]>0) 
//   {
//       posNum = posNum + array[i];
      
    
//   }
  
//   else 
//   {
//     negNum = negNum + array[i];
//   }
//   i=i+1;
  
// }
// Console.Write($", {posNum} , {negNum}");








// int [] array=new int[12];
// int posNum=0;
// int negNum=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(-9,10);
//     Console.Write(array[i]+" ");

//     if (array[i]>0)
//     {
//         posNum=posNum+array[i];
//     }
//     else
//     {
//         negNum=negNum+array[i];
//     }
// }
// Console.Write($"Сумма отрицательных: {negNum}, а положительных: {posNum}");

// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int [] array = new int[4];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-8,9);
//     Console.Write(array[i]+" ");
// }

// Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
//     Console.Write(array[i]+" ");
// }

// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// bool Include(int[] arr, int n)
// {
//   int i = 0;
//   while (i<arr.Length)
//   {
//     if (arr[i] == n)
//     {
//       return true;
//     }
//     i=i+1;
//   }
//   return false;
// }
// int[] array = new int [12];
// int i = 0;

// while (i<array.Length)
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write($" {array [i]} ");
//     i=i+1;
// }

// bool ans;
// int num = -2;
// ans = Include(array, num);
// Console.Write(ans);








// void FillArray(int[] collection) 
// {
// int length = collection.Length; 
// int index = 0;
// while (index < length)
// {
// collection[index] = new Random().Next(1, 10); 
// //index = index + 1;
// index++;
// }
// }
// void PrintArray(int[] col)
// {
// int count = col.Length;
// int position = 0;
// while (position < count)
// {
// Console.WriteLine(col[position]);
// position++;
// }
// }

// int IndexOf(int[] collection, int find) 
// {
// int count = collection.Length; 
// int index = 0;
// int position = -1;
// while (index < count)
// {
// if(collection[index] == find)
// {
//   position = index;
//   break;
// }
// index++; 
// }
// return position;
//  }

// int[] array = new int[10];
// FillArray(array);
// array[4]=4;
// array[8]=4;
// PrintArray(array);
// Console.WriteLine();


// int pos = IndexOf(array, 444);
// Console.WriteLine(pos);


// Задача 33: Задайте массив.
//  Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.

// void FillArray(int[] collection) 
// {
// int length = collection.Length; 
// int index = 0;
// while (index < length)
// {
// collection[index] = new Random().Next(1, 10); 
// //index = index + 1;
// index++;
// }
// }
// void PrintArray(int[] col)
// {
// int count = col.Length;
// int position = 0;
// while (position < count)
// {
// Console.WriteLine(col[position]);
// position++;
// }
// }

// int IndexOf(int[] collection, int find) 
// {
// int count = collection.Length; 
// int index = 0;
// int position = -1;
// while (index < count)
// {
// if(collection[index] == find)
// {
//   position = index;
//   break;
// }
// index++; 
// }
// return position;
//  }

// int[] array = new int[10];
// FillArray(array);
// array[4]=4;
// array[8]=4;
// PrintArray(array);
// Console.WriteLine();


// int pos = IndexOf(array, 444);
// Console.WriteLine(pos);

// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void FillArray(int[] collection) 
// {
// int length = collection.Length; 
// int index = 0;
// while (index < length)
// {
// collection[index] = new Random().Next(1, 201); 
// index++;

// }
// }
// void PrintArray(int[] col)
// {
// int count = col.Length;
// int position = 0;
// while (position < count)
// {
// Console.WriteLine(col[position]);
// position++;
// }
// }

// int IndexOf(int[] collection) 
// {
// int num=0;
// int count = collection.Length; 
// int index = 0;
// int position = -1;
// while (index < count)
// {
// if((collection[index] > 9) && (collection[index] < 100))
// {
//   num=num+1;
// }
// index++; 
// }
// return num;
//  }

// int[] array = new int[5];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// Console.WriteLine(IndexOf(array));
//________________ДЗ___________________________

// Задайте массив заполненный случайными положительными
// трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = new int [4];
// int i = 0;

// while (i<array.Length)
// {
//     array [i] = new Random().Next(100, 1000);
//     Console.Write($"{array [i]} ");
    
//     i=i+1;
          
// }
// int sum=0;
// i=0;
// for ( i = 0; i < array.Length; i=i+1)
// {
//     if (array[i]%2==0)
//     {
//         sum=sum+1;
//     }
    
//     }

// Console.Write($"-->{sum}");

// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int [4];
// int i = 0;

// while (i<array.Length)
// {
//     array [i] = new Random().Next(1, 100);
//     Console.Write($"{array [i]} ");
//     i=i+1;
// }
// // int sum= array[0]+array[2];
// // Console.Write($"--->{sum}");
// //или
// i=0;
// int sum=0;
// while (i<array.Length)
// {
//     sum=sum + array [i];
//     i=i+2;
    
// }
// Console.Write($"-->{sum}");


// Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] array = new double [5];
// int i = 0;
// Console.Write("Для массива { ");
// while (i<array.Length)
// {
//     array [i] = Math.Round(new Random().NextDouble()*100,2);
//     Console.Write(array [i] + " ");
//     i=i+1;
// }
// Console.Write("}");

// Console.WriteLine("\n");

// double maxNum;
// maxNum=array[0];
// double minNum;
// minNum=array[0];
// double diff=0;

// i=0;
// while (i<array.Length)
// {
//     if (array[i]>maxNum)
//     {
//         maxNum=array[i];
//     }

//     if (array[i]<minNum)
//     {
//         minNum=array[i];
//     }
//     i=i+1;

// }

// diff=maxNum-minNum;
// Console.WriteLine($"Минимальное значение - {minNum}. ");
// Console.WriteLine($"Максимальное значение - {maxNum}.");
// Console.WriteLine($"Разница - {diff}");