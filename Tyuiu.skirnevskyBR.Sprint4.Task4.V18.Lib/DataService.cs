using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.skirnevskyBR.Sprint4.Task4.V18.Lib
{
    public class DataService : ISprint4Task4V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i <= rows - 1; i++)
            {
                for (int j = 0; j <= cols - 1; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}