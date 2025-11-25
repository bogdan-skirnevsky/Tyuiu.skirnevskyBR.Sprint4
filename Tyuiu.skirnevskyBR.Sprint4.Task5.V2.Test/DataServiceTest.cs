using Tyuiu.skirnevskyBR.Sprint4.Task5.V2.Lib;
namespace Tyuiu.skirnevskyBR.Sprint4.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                {-7, 2, -3, 4, -5},
                {1, -2, 3, -4, 5},
                {-1, 2, -3, 4, -5},
                {0, -6, 3, -2, 1},
                {-4, 3, -1, 2, -7}
            };

            int res = ds.Calculate(matrix);
            int wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}
