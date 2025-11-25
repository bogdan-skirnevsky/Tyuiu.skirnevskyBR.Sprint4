using Tyuiu.skirnevskyBR.Sprint4.Task1.V19.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнил: Скрипневский Б.Р. | ИИКСб-23-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)            *");
Console.WriteLine("* Задание #1                                              *");
Console.WriteLine("* Вариант #19                                             *");
Console.WriteLine("* Выполнил: Скрипневский Богдан Романович | ИИКСб-23-1   *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов     *");
Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 2 до *");
Console.WriteLine("* 9 подсчитать сумму четных элементов массива.            *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int[] numsArray = new int[12];

Console.WriteLine("Введите 12 элементов массива (целые числа от 2 до 9):");
for (int i = 0; i < numsArray.Length; i++)
{
    Console.Write($"Элемент {i + 1}: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* Введенный массив:                                       *");
Console.WriteLine("***********************************************************");

for (int i = 0; i < numsArray.Length; i++)
{
    Console.WriteLine($"Элемент {i}: {numsArray[i]}");
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int res = ds.Calculate(numsArray);
Console.WriteLine("Сумма четных элементов массива = " + res);

Console.ReadKey();