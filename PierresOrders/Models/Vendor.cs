using System.Collections.Generic;

namespace PierresOrders.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorList = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    
    public Vendor(string vendorName, string vendorDescript)
    {
      Name = vendorName;
      Description = vendorDescript;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<Order>{};
    }
  }
}