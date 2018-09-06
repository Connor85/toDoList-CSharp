using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;

    private static List<Item> _instances = new List<Item>{};

    public Item (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Item> GetAll()
    {
    return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
  _instances.Clear();
  }
  }

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to the To Do List");
    Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
    string response = Console.ReadLine().ToLower();
    if (response == "add")
    {
      Console.WriteLine("Please enter the description for the new item");
      string userDescription = Console.ReadLine();
      Item newItem = new Item(userDescription);
      newItem.Save();
        Console.WriteLine("'" + userDescription + "'" + " has been added to your list. Would you like to add an item to your list of view your list? (Add/View)");

       string answer = Console.ReadLine().ToLower();
       if (answer == "view")
       {
          List<Item> instances = Item.GetAll();
          for (int i = 0; i < instances.Count; i++)
          {
            string instanceDescription = instances[i].GetDescription();
            Console.WriteLine((i + 1) + ". " + instanceDescription);
          }
        }
      else
      {
        Main();
      }
    }
  }
}
}
