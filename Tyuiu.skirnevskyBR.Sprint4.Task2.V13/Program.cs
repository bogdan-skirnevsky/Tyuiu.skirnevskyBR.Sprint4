using Tyuiu.skirnevskyBR.Sprint4.Task2.V13.Lib;

DataService ds = new DataService();
Random random = new Random();

Console.Title = "Спринт #4 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #4                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)             *");
Console.WriteLine("* Задание #2                                              *");
Console.WriteLine("* Вариант #13                                             *");
Console.WriteLine("* Выполнил: Скрипневский Богдан Романович | ИБКСб-25-1   *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов     *");
Console.WriteLine("* заполненный случайными значениями в диапазоне от 2 до 9 *");
Console.WriteLine("* подсчитать произведение четных элементов массива.       *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int[] numsArray = new int[13];

Console.WriteLine("Сгенерированный массив: ");
for (int i = 0; i <= numsArray.Length - 1; i++)
{
    numsArray[i] = random.Next(2, 10);
    Console.WriteLine(numsArray[i]);
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

int res = ds.Calculate(numsArray);
Console.WriteLine("Произведение четных элементов массива = " + res);

Console.ReadKey();