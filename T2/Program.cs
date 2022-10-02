// Задача 36: Задайте одномерный массив, заполненный случайными 
//числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
WriteLine("Введите размерность массива");
int length=Convert.ToInt32(ReadLine());
int[]array=GetArray(length);

PrintArray(array);
int S=SumUnevenPos(array);

WriteLine($"Сумма элементов массива с нечетными индексами = {S}");

//Заполнение массива
int[] GetArray(int size)
{
    int[]result=new int[size];
    for (int i=0; i<size; i++)
    {
       result [i]=new Random().Next(0, 10);
    }
    return result;
}

//Вывод массива
void PrintArray(int[]prarray)
{
    string prArray=String.Join(";",prarray);
WriteLine($"[{prArray}]");
}

//Сумма элементов нечетных индексов
int SumUnevenPos(int[]UnArray)
{
    int Sum=0;
    for(int k=1; k<UnArray.Length; k+=2)
    {
       Sum=Sum+UnArray[k];
    }
    return Sum;
}