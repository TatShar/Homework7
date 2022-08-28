// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    Console.Write (message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double [,] FillArray(int rows, int coloumns)

{   
    double [,] array = new double [rows,coloumns];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next();
        }
    }
    return array;
}

void PrintArray(double [,] array)
{
  for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");;
        }
        Console.WriteLine();
    }  
}

int rows=Prompt("Введите количество строк: ");
int coloumns = Prompt("Введите количество столбцов: ");

double [,] array = FillArray(rows, coloumns);
PrintArray(array);
