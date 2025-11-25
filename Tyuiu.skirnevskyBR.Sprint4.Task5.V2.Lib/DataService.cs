using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.skirnevskyBR.Sprint4.Task5.V2.Lib
{
    public class DataService : ISprint4Task5V2
    {
        public int Calculate(int[,] matrix)
        {
            int wait = 0;
            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        wait++;
                    }
                }
            }
            return wait;
        }
    }
}