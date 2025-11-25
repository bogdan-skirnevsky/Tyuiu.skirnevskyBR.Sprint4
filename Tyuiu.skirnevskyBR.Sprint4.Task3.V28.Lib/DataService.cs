using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.skirnevskyBR.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int wait = 9; 
            for (int i = 0; i <= array.GetLength(0) - 1; i++)
            {
                if (array[i, 3] < wait)
                {
                    wait = array[i, 3];
                }
            }
            return wait;
        }
    }
}