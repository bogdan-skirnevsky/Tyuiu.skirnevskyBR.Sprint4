using Tyuiu.skirnevskyBR.Sprint4.Task5.V2.Lib;

DataService ds = new DataService();
Random random = new Random();

Console.Title = "Спринт #4 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Двумерные массивы (генерация случайных чисел)     *");
Console.WriteLine("* Задание #5                                              *");
Console.WriteLine("* Вариант #2                                              *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,    *");
Console.WriteLine("* заполненный случайными значениями в диапазоне от -7 до 5*");
Console.WriteLine("* Найти количество отрицательных элементов.               *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int[,] matrix = new int[5, 5];

Console.WriteLine("Сгенерированный массив (диапазон -7 до 5):");
for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
{
    for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
    {
        matrix[i, j] = random.Next(-7, 6); // от -7 до 5 включительно
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int res = ds.Calculate(matrix);
Console.WriteLine("Количество отрицательных элементов = " + res);

Console.ReadKey();