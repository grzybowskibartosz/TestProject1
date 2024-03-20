using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void test_poprowanosci_wypisywania()
        {
            // Arrange
            List<Item> przedmiotyWplecaku = new List<Item>
            {
                new Item(10, 60),
                new Item(20, 100),
                new Item(30, 120)
            };
            Result result = new Result(60, 220, przedmiotyWplecaku);

            // Act
            string resultString = result.ToString();

            // Assert
            Assert.AreEqual("Total weight: 60 | Total value: 220\nItems in the backpack: \nWeight: 10 | Value: 60\nWeight: 20 | Value: 100\nWeight: 30 | Value: 120\n", resultString);
        }
    }
}
