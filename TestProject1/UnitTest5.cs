using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void poprawnosc_od_kolejonsci()
        {
            // Arrange
            List<Item> listaPrzedmiotów1 = new List<Item>
            {
                new Item(10, 60),
                new Item(20, 100),
                new Item(30, 120)
            };

            List<Item> listaPrzedmiotów2 = new List<Item>
            {
                new Item(20, 100),
                new Item(30, 120),
                new Item(10, 60)
            };

            Problem problem1 = new Problem(listaPrzedmiotów1.Count, 14);
            Problem problem2 = new Problem(listaPrzedmiotów2.Count, 14);

            problem1.Items = listaPrzedmiotów1;
            problem2.Items = listaPrzedmiotów2;

            // Act
            Result wynik1 = problem1.Solve(50);
            Result wynik2 = problem2.Solve(50);

            // Assert
            Assert.AreEqual(wynik1.total_weight, wynik2.total_weight);
            Assert.AreEqual(wynik1.total_value, wynik2.total_value);
        }
    }
}
