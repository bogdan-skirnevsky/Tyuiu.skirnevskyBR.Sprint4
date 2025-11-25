using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.skirnevskyBR.Sprint4.Task7.V28.Lib
{
    public class DataService : ISprint4Task7V28
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            int wait = 1;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        wait *= matrix[i, j];
                    }
                }
            }
            return wait;
        }
    }
}