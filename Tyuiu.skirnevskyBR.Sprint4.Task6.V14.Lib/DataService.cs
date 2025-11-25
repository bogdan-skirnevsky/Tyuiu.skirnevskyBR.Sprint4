using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.skirnevskyBR.Sprint4.Task6.V14.Lib
{
    public class DataService : ISprint4Task6V14
    {
        public string[] Calculate(string[] array)
        {
            int count = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i].Length > 3)
                {
                    count++;
                }
            }

            string[] wait = new string[count];
            int index = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i].Length > 3)
                {
                    wait[index] = array[i];
                    index++;
                }
            }

            return wait;
        }
    }
}