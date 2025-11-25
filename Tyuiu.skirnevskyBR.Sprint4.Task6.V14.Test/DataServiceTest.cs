using Tyuiu.skirnevskyBR.Sprint4.Task6.V14.Lib;
namespace Tyuiu.skirnevskyBR.Sprint4.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" }; // Длина > 3 символов

            CollectionAssert.AreEqual(wait, res);
        }
    }
}