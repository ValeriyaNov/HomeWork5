// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using static System.Console;
Clear();
WriteLine("Введите размерность массива");
int length=Convert.ToInt32(ReadLine());

int[]array=GetArray(length);
PrintArray(array);
int N=FindEvenNumber(array);
WriteLine($"Количество четных чисел массива = {N}");


//Заполнение массива
int[] GetArray(int size)
{
    int[]result=new int[size];
    for (int i=0; i<size; i++)
    {
       result [i]=new Random().Next(100, 1000);
    }
    return result;
}

//Вывод массива
void PrintArray(int[]prarray)
{
    string prArray=String.Join(",",prarray);
WriteLine($"[{prArray}]");
}

//Метод нахождения четных чисел
int FindEvenNumber(int[]EvArray)
{
    int count=0;
    for (int j=0; j<EvArray.Length; j++)
    {
    if((EvArray[j]%2)==0) count++;
    }
    return count;
}

