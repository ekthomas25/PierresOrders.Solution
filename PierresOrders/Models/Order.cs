using System.Collections.Generic;
using System;

namespace PierresOrders.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    private static List<Order> _orderList = new List<Order> { };
    public Order(string title, string description, int price, int date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _orderList.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _orderList;
    }

    public static void ClearAll()
    {
      _orderList.Clear();
    }
  }
}