using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_plecakowy;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void poprawnosc_rozwiazania()
        {
            Problem problem = new Problem(3, 14);

            problem.Items[0] = new Item(10, 60);
            problem.Items[1] = new Item(20, 100);
            problem.Items[2] = new Item(30, 120);

            int oczekiwana_wartosc = 160;
            int oczekiwana_waga = 30;

            Result wynik = problem.Solve(50);

            Assert.AreEqual(oczekiwana_waga, wynik.total_weight);
            Assert.AreEqual(oczekiwana_wartosc, wynik.total_value);
        }
    }
}
