using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void sprawdzanie_poprawnosci_sortowania()
        {
            Problem problem = new Problem(3, 15);

            problem.Items = new List<Item>
            {
                new Item (80, 100),
                new Item (50, 100),
                new Item (20, 100),
            };

            List<Item> items_sorted = new List<Item>
            {
                new Item(20, 100),
                new Item (50, 100),
                new Item (80, 100),
            };

            Result wynik = problem.Solve(300);

            Assert.IsTrue((problem.Items[0].weight == items_sorted[0].weight) && (problem.Items[1].weight == items_sorted[1].weight) && (problem.Items[2].weight == items_sorted[2].weight));
        }
    }
}
