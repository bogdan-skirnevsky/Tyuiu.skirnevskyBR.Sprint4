using Tyuiu.skirnevskyBR.Sprint4.Task1.V19.Lib;
namespace Tyuiu.skirnevskyBR.Sprint4.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 32; 
            Assert.AreEqual(wait, res);
        }
    }
}
