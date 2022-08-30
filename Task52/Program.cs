// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int [,] FillArray (int rows, int coloumns)

// {
//     int [,] arr = new int[rows,coloumns];
//     for (int i=0; i< arr.GetLength(0); i++)
//     {
//         for (int j=0; j<arr.GetLength(1); j++)
//         {
//             arr[i,j]= new Random().Next(1,10);
//         }
//     }
//     return arr;
// }
//  void PrintArray(int [,] arr)
//  {
//     for (int i=0; i< arr.GetLength(0); i++)
//     {
//         for (int j=0; j<arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
//  }

//  int GetSredArr(int[,] arr)
//  {
//     int count = 1;
//     int srAr=arr[0,0];
    
//         for (int i =0; i<arr.GetLength(0); i++)
//         {
//             srAr = (arr[i+1,0])/count;
//             count++;
//         }       
//     return srAr;
//  }
//  int [,] array = FillArray(5,5);
//  PrintArray(array);
//  int srArr=GetSredArr(array);

int[,] arr = new int [3,3];
for (int i=0; i< arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j]= new Random().Next(1,10);
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
int sum = 0;
double srArr=0;
int coloumns=0;
while (coloumns<arr.GetLength(1))
{
for (int rows=0; rows<arr.GetLength(0); rows++)
{
    sum +=arr[rows,coloumns];
    
}
srArr= (double) sum/arr.GetLength(0);
Console.Write($"Среднее арифмитическое столбца {coloumns+1}:" + $"{srArr:F2}");
Console.WriteLine();
coloumns++;
sum=0;
}

