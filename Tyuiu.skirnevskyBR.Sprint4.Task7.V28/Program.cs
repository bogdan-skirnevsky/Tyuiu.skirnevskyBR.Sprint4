using Tyuiu.skirnevskyBR.Sprint4.Task7.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Обработка строковых данных                        *");
Console.WriteLine("* Задание #7                                              *");
Console.WriteLine("* Вариант #28                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр '623351179845632'.    *");
Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте          *");
Console.WriteLine("* произведение четных чисел.                              *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int n = 5;
int m = 3;
string value = "623351179845632";

Console.WriteLine("Строка: " + value);
Console.WriteLine("Размер матрицы: " + n + " x " + m);

int[,] matrix = new int[n, m];
int index = 0;
Console.WriteLine("Полученная матрица:");
for (int i = 0; i <= n - 1; i++)
{
    for (int j = 0; j <= m - 1; j++)
    {
        matrix[i, j] = int.Parse(value[index].ToString());
        Console.Write(matrix[i, j] + " ");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int res = ds.Calculate(n, m, value);
Console.WriteLine("Произведение четных чисел = " + res);

Console.ReadKey();