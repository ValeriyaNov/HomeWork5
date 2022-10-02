//Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
using static System.Console;
Clear();
WriteLine("Введите размерность массива");
int length=Convert.ToInt32(ReadLine());
double[]array=GetArray(length);

PrintArray(array);
double m=Max(array);
double n=Min(array);

WriteLine($"Разница между максимальным и минимальным элементами = {m-n}");




//Заполнение массива
double[] GetArray(int size)
{
    Random rnd=new Random();
    double[] result=new double[size];
    for (int i=0; i<result.Length; i++)
    {
        result[i]=rnd.Next(1, 125) + Math.Round(rnd.NextDouble(),3);
    }
    return result;
}

//Вывод массива
void PrintArray(double[]prarray)
{
    string prArray=String.Join(" | ",prarray);
WriteLine($"[{prArray}]");
}

//Нахождение максимального элемента
double Max(double[]MaxArray)
{
    double max = MaxArray[0];
    for(int g=1; g<MaxArray.Length; g++)
    {
       if(MaxArray[g]>max)
       {
        max = MaxArray[g];
       }
    }
    return max;
}

//Нахождение минимального элемента
double Min(double[]MinArray)
{
    double min = MinArray[0];
    for(int l=1; l<MinArray.Length; l++)
    {
       if(MinArray[l]<min)
       {
        min = MinArray[l];
       }
    }
    return min;
}

