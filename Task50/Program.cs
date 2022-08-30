// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

   int Prompt (string message)
   {
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
   }
    
    int [,] FillArray (int rows, int coloumns)
    {
        int [,] arr= new int [rows,coloumns];
        for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=0; j<arr.GetLength(1); j++)
            {
                arr[i,j]= new Random().Next(1,10);
            }
        }
        return arr;
    }

 void PrintArray (int[,] arr)
 {
    for (int i=0; i<arr.GetLength(0); i++)
        {
            for (int j=0; j<arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        } 
 }

 void GetElement (int[,] array, int a, int b)

 {
    for (int i=0; i<array.GetLength(0); i++)
        {
            for (int j=0; j<array.GetLength(1); j++)
            {
                if(i==a && j==b)
                {
                    Console.Write ("Запрошенный элемент: "+array[i,j]);
                    
                }
            }
            Console.WriteLine();
        } 
    Console.Write("Такого элемента нет");
 }

   int a = Prompt("Input index a: ")-1;
   int b = Prompt("Input index b: ")-1; 
   int [,] array = FillArray(3,3);
   PrintArray(array);
   GetElement(array, a,b);

        
         
