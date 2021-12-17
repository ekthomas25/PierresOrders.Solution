using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrders.Models;
using System.Collections.Generic;
using System;

namespace PierresOrders.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  }
}