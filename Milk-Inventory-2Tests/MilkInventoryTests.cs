using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MilkInventory2.Tests
{
    [TestClass()]
    public class MilkInventoryTests
    {
        [TestMethod()]
        public void GetInventoryTest()
        {
            var milkInventory = new MilkInventory();
            milkInventory.Amount = 298;

            var inventory = milkInventory.GetInventory();
            Assert.AreEqual(298, inventory); 
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            var milkInventory = new MilkInventory();
            milkInventory.Amount = 298;

            var amountAfterWithdraw = milkInventory.Withdraw(290);
            Assert.AreEqual(8, amountAfterWithdraw);
        }

        [TestMethod()]
        public void AddTest()
        {
            var milkInventory = new MilkInventory();
            milkInventory.Amount = 298;

            var amountAfterAdd = milkInventory.Add(102);
            Assert.AreEqual(400, amountAfterAdd);
        }
    }
}