using Tyuiu.skirnevskyBR.Sprint4.Task7.V28.Lib;
namespace Tyuiu.skirnevskyBR.Sprint4.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "623351179845632";
            int res = ds.Calculate(n, m, value);

            int wait = 4608;

            Assert.AreEqual(wait, res);
        }
    }
}