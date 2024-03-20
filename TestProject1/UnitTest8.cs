using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]
        public void test_dla_identycznych_itemow()
        {
            Problem problem = new Problem(4, 20);

            problem.Items = new List<Item>
            {
                new Item (5, 5),
                new Item (5, 5),
                new Item (5, 5),
                new Item (5, 5)
            };

            Result result = problem.Solve(15);
            int true_total_value = 15;

            Assert.AreEqual(true_total_value, result.total_value);
        }
    }
}
