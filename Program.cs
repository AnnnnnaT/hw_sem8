

int [,] Create2dArray ()

{ 
    Console.WriteLine("Input number of rows: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number ofcolumns: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min number of 2d array: ");
    int min =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max number of 2d array: ");
    int max =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int [,] array = new int [rows, columns];
    for (int i = 0; i< rows; i++)
    {
        for  (int j = 0; j< columns; j++)
        array [i,j] = new Random().Next(min, max+1);
    }

    return array;
    
}


void Show2dArray (int [,] array)

{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for  (int j = 0; j< array.GetLength(1); j++)
       {    
           Console.Write(array[i, j] + " ");
       }

      Console.WriteLine();
    }
    
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
void ChangeOrder (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            for (int m = j + 1; m < array.GetLength(1); m++)
            {
                if (array[i, m] >  array [i,j])
                {
                    int n = array[i, j];
                    array[i, j] = array[i, m];
                    array[i, m] = n;
                }
            }
        
        }
    }
}
 
int [,] myarray = Create2dArray();
Show2dArray(myarray);
Console.WriteLine();
ChangeOrder(myarray);
Show2dArray(myarray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*

int FindMinSumString (int [,] array)
{

int summin = Int32.MaxValue;
int index = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum+=array[i, j];        
    }
    if (sum < summin)
    {
        summin = sum;
        index++;
    }
}
return index;
}
 
int [,] myarray = Create2dArray();
Show2dArray(myarray);
Console.WriteLine();
int res = FindMinSumString(myarray);
Console.WriteLine($"String with min sum of elements is {res}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int [,] MultiplyMatrices (int[,] matrix1, int [,] matrix2)
{   
    int size = matrix1.GetLength(0);

    int[,] result = new int [size, size]; 
        
        if (matrix1.GetLength(0) == matrix2.GetLength(1))
        {            
           for (int i = 0; i < size; i++)
           {
            for (int j = 0; j <size; j++)
            {
                for (int k = 0; k <size ; k++)
                { 
                   result [i,j] =  result [i,j] + (matrix1[i,k]*matrix2[k,j]);
                }
               
            }    
            }
        }
            
       else
       {
       Console.WriteLine(" matrices can't be multiplied");
       }
    return result; 
}

Console.WriteLine("Create your 1st matrix:");
int [,] matrix1 = Create2dArray();
Console.WriteLine("1st matrix: ");
Show2dArray(matrix1);
Console.WriteLine();

Console.WriteLine("Create your 2nd matrix:");
int [,] matrix2 = Create2dArray();
Console.WriteLine("2nd matrix: ");
Show2dArray(matrix2);
Console.WriteLine();

int [,] res = MultiplyMatrices (matrix1, matrix2);
Show2dArray(res);
*/


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int [,,] Create3Darray ()
{
    Console.WriteLine("Input number of 1st measure: ");
    int rows =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of 2nd measure: ");
    int columns =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of 3d measure: ");
    int depth =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min number of 3d array: ");

    int numbers = 89;

    if (rows*columns*depth>numbers)
    {
        Console.WriteLine("Array is very big");
    }

    int [,,] array = new int [rows, columns, depth];

        int[] help = new int[numbers];
            int n = 10;
            for (int i = 0; i < help.Length; i++)
            {
            help [i] = n++;  
            }
            for (int i = 0; i < help.Length; i++)
            {
            int anyindex = new Random().Next(0, help.Length);
            int temp = help[i];
            help [i] = help [anyindex];
            help [anyindex] = temp;  
            }
    
    
    int helpIndex = 0;

    for (int i= 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = help[helpIndex];
                helpIndex++;
            }
        }
    }
    return array;
}

void Show3DArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} - [{i},{j},{k}] ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}

int [,,] myArray = Create3Darray();
Show3DArray(myArray);
*/
 
//  Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int [,] SpiralArray ()
{
    Console.WriteLine("Input size of array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[size, size];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= size * size)
    {
        array [i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            i++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            i--;
        num++;
    }
  return array;
}  

void ShowSpiral (int [,] array, int fillToSigns = 2)

{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for  (int j = 0; j< array.GetLength(1); j++)
       {    
           Console.Write(array[i, j].ToString($"D{fillToSigns}") + " ");
       }

      Console.WriteLine();
    }
    
}

int [,] spiral = SpiralArray();
ShowSpiral(spiral);
*/

