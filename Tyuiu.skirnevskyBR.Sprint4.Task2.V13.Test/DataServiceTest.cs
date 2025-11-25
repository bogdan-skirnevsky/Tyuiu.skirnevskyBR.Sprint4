using Tyuiu.skirnevskyBR.Sprint4.Task2.V13.Lib;
namespace Tyuiu.skirnevskyBR.Sprint4.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 3, 6, 7, 8, 5, 2, 9, 4, 3, 6, 5, 8 };
            int res = ds.Calculate(numsArray);
            int wait = 4 * 6 * 8 * 2 * 4 * 6 * 8; 
            Assert.AreEqual(wait, res);
        }
    }
}
