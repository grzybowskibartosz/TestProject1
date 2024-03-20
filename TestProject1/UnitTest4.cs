using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void test_wyniku_bez_przedmiotow()
        {
            // Arrange
            Problem problem = new Problem(3, 14);
           

            foreach(var item in problem.Items)
            {
                item.weight = 100;
            }

            // Act
            Result wynik = problem.Solve(5);

            // Assert
            Assert.AreEqual(0, wynik.Items_packed.Count);
        }
    }
}
