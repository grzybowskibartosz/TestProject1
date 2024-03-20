using Problem_plecakowy;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_z_przykladu()
        {
            List<int> sizes = new List<int>() { 10, 20 ,30 ,40 ,50 };
            foreach (int n in sizes) 
            {
                Problem problem = new Problem(n, 13);
                Assert.AreEqual(n, problem.Items.Count);
            
            }
        }
    }
}