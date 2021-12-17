using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrders.Models;
using System.Collections.Generic;

namespace PierresOrders.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod] //Test 1
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Title", "Description", 4, 211217);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    
    [TestMethod] //Test 2
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrder, result);
    }
  }
}