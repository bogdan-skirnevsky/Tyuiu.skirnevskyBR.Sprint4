using Tyuiu.skirnevskyBR.Sprint4.Task3.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Двумерные массивы (статический ввод)              *");
Console.WriteLine("* Задание #3                                              *");
Console.WriteLine("* Вариант #28                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1   *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,    *");
Console.WriteLine("* заполненный статическими значениями в диапазоне от 4 до *");
Console.WriteLine("* 9. Найдите минимальный элемент в четвертом столбце.    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int[,] numsArray = new int[5, 5] {
    {5, 4, 9, 8, 5},
    {4, 6, 6, 9, 9},
    {9, 8, 4, 8, 8},
    {6, 8, 6, 8, 9},
    {9, 4, 6, 6, 7}
};

Console.WriteLine("Массив:");
for (int i = 0; i <= numsArray.GetLength(0) - 1; i++)
{
    for (int j = 0; j <= numsArray.GetLength(1) - 1; j++)
    {
        Console.Write(numsArray[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int res = ds.Calculate(numsArray);
Console.WriteLine("Минимальный элемент в четвертом столбце = " + res);

Console.ReadKey();