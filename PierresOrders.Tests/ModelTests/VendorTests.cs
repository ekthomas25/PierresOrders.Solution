using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrders.Models;
using System.Collections.Generic;
using System;

namespace PierresOrders.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetDetails_ReturnsName_String()
    {
      string name = "Kevin and Suzie's Bar";
      string description = "A Bar";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDetails_ReturnsDescription_String()
    {
      string name = "Kevin and Suzie's Bar";
      string description = "A Bar";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_VendorsAreAssignedAnId_Int()
    {
      string name = "Kevin and Suzie's Bar";
      string description = "A Bar";
      Vendor newVendor = new Vendor(name, description);
      
      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Kevin's Kafe";
      string description1 = "A Cafe";
      string name2 = "Suzie's Bar";
      string description2 = "A Bar";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsVendorBasedOnId_Vendor()
    {
      string name1 = "Kevin's Kafe";
      string description1 = "A Cafe";
      string name2 = "Suzie's Bar";
      string description2 = "A Bar";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor_OrderList()
    {
      string title = "Order # 1";
      string orderDescription = "a million baguettes, extra crispy";
      int price = 50;
      int date = 211217;
      Order newOrder = new Order(title, orderDescription, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name1 = "Kevin's Kafe";
      string description1 = "A Cafe";
      Vendor newVendor = new Vendor(name1, description1);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}