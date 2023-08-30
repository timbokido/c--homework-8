// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] a = new int[m, n];

for (int i = 0; i < m; i++) //filling of array
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = new Random().Next(0, 100);
        Console.Write($"{a[i, j]} ");
    }
    Console.WriteLine();
}

int count = 0;
for (int i = 0; i < n; i++)
{
    count += a[0, i];
}

int index = 0;
int temp = 0;
for (int i = 1; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        temp += a[i, j];
    }
    if (temp < count)
    {
        count = temp;
        index = i;
    }
    temp = 0;
}

Console.Write($"строка с наименьшей суммой под номером {index + 1}");