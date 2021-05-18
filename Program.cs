using System;
using System.Collections.Generic;
using cslogin.Models;

namespace cslogin
{
  class Program
  {
    static void Main(string[] args)
    {
      //#3
      Dictionary<string, User> users = new Dictionary<string, User>();
      User Mick = new User("Mick", "mypassword");
      users.Add(Mick.Name, Mick);


      //#2
      //console.clear()
      Console.WriteLine("Please login to continue.");
      //#5 add extras: bool valid = true. while, wrap all below text in while loop

      System.Console.Write("Username: ");
      string username = Console.ReadLine();
      Console.Write("\nPassword: ");
      string password = Console.ReadLine();

      //#4
      //   just users[username] doesn't work.
      if (users.ContainsKey(username) && users[username].ValidatePassword(password))
      {
        System.Console.WriteLine("Successfully Logged In");
      }
      else
      {
        System.Console.WriteLine("Incorrect Username or Password");
      }

      System.Console.WriteLine($"user: {username} password: {password}");
    }
  }
}
