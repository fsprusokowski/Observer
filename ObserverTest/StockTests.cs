using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.Class;

namespace ObserverTest
{
    [TestClass]
    public class StockTests
    {
        [TestMethod]
        public void Stock_NotifyAllWhenSetValue()
        {
            var stock = new Stock("Apple", 100);
            var ohioTechInvestor = new OhioTechInvestor(stock);
            var goldenSeedsInvestor = new GoldenSeedsInvestor(stock);
           
            stock.Value = 150;
            Assert.AreEqual(2, stock.Notified);
        }

        [TestMethod]
        public void Stock_NotifyAll()
        {
            var stock = new Stock("Apple", 100);
            var ohioTechInvestor = new OhioTechInvestor(stock);

            stock.NotifyAll();
            Assert.AreEqual(1, stock.Notified);
        }

        [TestMethod]
        public void Stock_WithouInvestorNoNotifications()
        {
            var stock = new Stock("Apple", 100);

            Assert.AreEqual(0, stock.Notified);
            stock.NotifyAll();
            Assert.AreEqual(0, stock.Notified);
        }

        [TestMethod]
        public void Stock_AttachingInvestor()
        {
            var stock = new Stock("Apple", 100);
            var ohioTechInvestor = new OhioTechInvestor();

            Assert.AreEqual(0, stock.GetNumOfInvestors());

            stock.attach(ohioTechInvestor);

            Assert.AreEqual(1, stock.GetNumOfInvestors());
        }
    }
}
