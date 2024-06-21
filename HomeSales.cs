using System;

class Program {
   static void Main (string[] args) 
  {
    //Array to store the names of salespeople
    string[] salespeople = { "Danielle", "Edward", "Francis" };
    //Array to store the initials for each salesperson
    char[] initials = { 'D', 'E', 'F' };
    //Array to store the sales values for each salesperson
    double[] sales = new double[salespeople.Length];

    //Loop to prompt for salesperson initials and sale amounts
    while (true)
    {
      //Prompt user for salesperson initial
      Console.Write("Enter salesperson initial (D, E, F) or Z to quit: ");
      string input = Console.ReadLine().ToUpper();

      //Check if user wants to quit loop
      if (input == "Z")
      {
        break;
      }

      //Find index of entered initial in initials array
      int index = Array.IndexOf(initials, input[0]);
      //If the inital is not found, display error message
      if (index == -1)
      {
        Console.WriteLine("Invalid initial. Please try again.");
        continue;
      }

      //Prompt user for sale value
      Console.Write("Enter sales amount: ");
      if (!double.TryParse(Console.ReadLine(), out double saleAmount) || saleAmount < 0)
      {
        Console.WriteLine("Invalid sales amount. Please try again.");
        continue;
      }

      //Add sale amount to corresponding salesperson's total
      sales[index] += saleAmount;
    }

    //Variables to keep track of grand total and top salesperson
    double grandTotal = 0;
    double maxSales = 0;
    string topSalesPerson = "";

    //Calculate the grand total and determine the top salesperson
    for (int i = 0; i < salespeople.Length; i++)
    {
      grandTotal += sales[i];
      if (sales[i] > maxSales)
      {
        maxSales = sales[i];
        topSalesPerson = salespeople[i];
      }
    }

    //Display sales for each salesperson, grand total, and top salesperson
    Console.WriteLine();
    for (int i = 0; i < salespeople.Length; i++)
    {
      Console.WriteLine($"{salespeople[i]}: {sales[i]}");
    }
    Console.WriteLine();
    Console.WriteLine($"Grand Total: {grandTotal}");
    Console.WriteLine($"Top Salesperson: {topSalesPerson}");
  }
}