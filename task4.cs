// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите размерность массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (m * n * b > 90)
{
    Console.WriteLine("нет столько разных двухзначных чисел");
    Environment.Exit(0);
}

int[,,] a = new int[m, n, b];
// --> array with random digits
int[] num = new int[90];
int temp;
int j;
for (int i = 0; i < 90; i++)
{
    num[i] = i + 10;
}
Console.WriteLine("");
Console.WriteLine("");

for (int i = 0; i < 90; i++)
{
    j = new Random().Next(1, 90);
    temp = num[i];
    num[i] = num[j];
    num[j] = temp;
}
for (int i = 0; i < 90; i++)
{
    Console.Write($"{num[i]} ");
}

// <--
Console.WriteLine("");
Console.WriteLine("");

int count = 0;
for (int i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        for (int k = 0; k < b; k++)
        {
            a[i, j, k] = num[count];
            Console.Write($"{a[i, j, k]}({i},{j},{k}) ");
            count++;
        }
    }
}
