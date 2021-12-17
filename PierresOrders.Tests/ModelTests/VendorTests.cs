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

    [TestMethod] //Test 6
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod] //Test 7
    public void GetDetails_ReturnsName_String()
    {
      string name = "Kevin and Suzie's Bar";
      string description = "A Bar";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod] //Test 8
    public void GetDetails_ReturnsDescription_String()
    {
      string name = "Kevin and Suzie's Bar";
      string description = "A Bar";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod] //Test 9
    public void GetId_VendorsAreAssignedAnId_Int()
    {
      string name = "Kevin and Suzie's Bar";
      string description = "A Bar";
      Vendor newVendor = new Vendor(name, description);
      
      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod] //Test 10
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

    [TestMethod] // Test 11
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
  }
}