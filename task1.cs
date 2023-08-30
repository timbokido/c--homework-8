// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] a = new int[m, n];

for (int i = 0; i < m; i++) //filling of array
{ 
    for (int j = 0; j < n; j++)
    {
        a[i, j] = new Random().Next(0, 100);
        Console.Write($"{a[i, j]} "); //initial output
    }
    Console.WriteLine();
}

int temp; 
for (int c = 0; c < n-1; c++) //sorting
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {

            if (a[i, j] < a[i, j + 1])
            {
                temp = a[i, j];
                a[i, j] = a[i, j + 1];
                a[i, j + 1] = temp;
            }

        }
    }
}

for (int i = 0; i < m; i++) //final output
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}