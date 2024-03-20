using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void test_wyniku_z_jednego_itemu()
        {
            // Arrange

            Problem problem = new Problem(3, 14);
            problem.Items = new List<Item> 
            {
                new Item(10, 60), // Przedmiot, który zmieści się w plecaku
                new Item(100, 1000), // Przedmiot, który nie zmieści się w plecaku
                new Item(55, 100) // Przedmiot, który nie zmieści się w plecaku
            };
            // Act
            Result wynik = problem.Solve(50);

            // Assert
            Assert.IsTrue(wynik.Items_packed.Count > 0);
        }
    }
}
