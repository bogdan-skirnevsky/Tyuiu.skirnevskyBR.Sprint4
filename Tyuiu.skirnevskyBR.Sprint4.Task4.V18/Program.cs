using Tyuiu.skirnevskyBR.Sprint4.Task4.V18.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)             *");
Console.WriteLine("* Задание #4                                              *");
Console.WriteLine("* Вариант #18                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,    *");
Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 4 до *");
Console.WriteLine("* 7. Заменить нечетные элементы массива на 0.             *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int[,] matrix = new int[5, 5];

Console.WriteLine("Введите 25 элементов массива (целые числа от 4 до 7):");
for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
{
    for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
    {
        Console.Write($"Элемент [{i},{j}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Введенный массив:");
for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
{
    for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int[,] resultMatrix = ds.Calculate(matrix);

Console.WriteLine("Массив после замены нечетных элементов на 0:");
for (int i = 0; i <= resultMatrix.GetLength(0) - 1; i++)
{
    for (int j = 0; j <= resultMatrix.GetLength(1) - 1; j++)
    {
        Console.Write(resultMatrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.ReadKey();