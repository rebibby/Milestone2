using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Milestone2_Tests
{
    namespace Milestone2_Tests
    {
        [TestClass()]
        public class InventoryItemTests
        {
            private string name = "Test Item";
            private string desc = "This is a test item";
            private int quantity = 10;
            private decimal price = 18.126M;
            private decimal modelID = 132;

            [TestMethod()]
            public void InventoryItemTest()
            {
                InventoryItem item = new InventoryItem(name, desc, quantity, price, modelID);
                Assert.IsNotNull(item);
                Assert.AreEqual(name, item.Name);
                Assert.AreEqual(desc, item.Description);
                Assert.AreEqual(quantity, item.Quantity);
                Assert.AreEqual(18.13M, item.Price);
                Assert.AreEqual(modelID, item.ModelID);
            }

            [TestMethod()]
            public void purchaseItemTest()
            {
                InventoryItem item = new InventoryItem(name, desc, quantity, price, modelID);
                Assert.IsTrue(item.PurchaseItem(1));
                Assert.IsFalse(item.PurchaseItem(10));
            }

            [TestMethod()]
            public void OutOfStockTest()
            {
                InventoryItem item = new InventoryItem(name, desc, quantity, price, modelID);
                Assert.IsFalse(item.OutOfStock());
                item.PurchaseItem(10);
                Assert.IsTrue(item.OutOfStock());
            }
        }
    }
