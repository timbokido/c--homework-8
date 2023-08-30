// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите размерность первого массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность второго массива");
int b = Convert.ToInt32(Console.ReadLine());
int v = Convert.ToInt32(Console.ReadLine());
if (n != b)
{
    Console.WriteLine("такие матрицы не перемножить");
    Environment.Exit(0);
}
int[,] a1 = new int[m, n];

Console.WriteLine();
for (int i = 0; i < m; i++) //filling of array a1
{
    for (int j = 0; j < n; j++)
    {
        a1[i, j] = new Random().Next(0, 100);
        Console.Write($"{a1[i, j]} ");
    }
    Console.WriteLine();
}

int[,] a2 = new int[b, v];

Console.WriteLine();
for (int i = 0; i < b; i++) //filling of array a2
{
    for (int j = 0; j < v; j++)
    {
        a2[i, j] = new Random().Next(0, 100);
        Console.Write($"{a2[i, j]} ");
    }
    Console.WriteLine();
}





int[,] r = new int[m, v]; //multiplication
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < v; j++)
    {
        for (int k = 0; k < b; k++)
        {
            r[i, j] += a1[i, k] * a2[k, j];
        }
    }
}

Console.WriteLine();
for (int i = 0; i < 3; i++) //final output
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write($"{r[i, j]} ");
    }
    Console.WriteLine();
}