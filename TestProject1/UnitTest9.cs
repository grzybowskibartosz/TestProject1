using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]
        public void test_gdy_nie_ma_itemow()
        {
            Problem problem = new Problem(0, 14);
            Result result = problem.Solve(10);

            Assert.AreEqual(0, result.Items_packed.Count);
            Assert.AreEqual(0, result.total_weight);
            Assert.AreEqual(0, result.total_value);
        }
    }
}
