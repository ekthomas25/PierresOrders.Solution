using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrders.Models;

namespace PierresOrders.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod] //Test 1
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}