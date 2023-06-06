// // Задача 31: Задайте массив из 12 элементов,
// // заполненный случайными 
// // числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// // сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

void FillArray(int[] collection) 
{
int length = collection.Length; 
int index = 0;
while (index < length)
{
collection[index] = new Random().Next(1, 201); 
index++;

}
}
void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while (position < count)
{
Console.WriteLine(col[position]);
position++;
}
}

int IndexOf(int[] collection) 
{
int num=0;
int count = collection.Length; 
int index = 0;
int position = -1;
while (index < count)
{
if((collection[index] > 9) && (collection[index] < 100))
{
  num=num+1;
}
index++; 
}
return num;
 }

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine(IndexOf(array));