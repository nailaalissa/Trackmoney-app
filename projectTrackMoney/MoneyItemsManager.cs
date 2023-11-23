using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace projectTrackMoney
{


    public class MoneyItemsManager :Print
    {

        public List<MoneyItem> items = new List<MoneyItem>();
       
        // Method to add new Income or Expense 
        public void AddItem()
        {
            string addChoice = Console.ReadLine();
            string type = "";
            switch (addChoice)     // categorize income and expense
            {
                case "1":
                    type = "Income";
                    break;
                case "2":
                    type = "Expense";
                    break;
                case "3":
                    return; // Back to the main menu
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }


            Console.WriteLine("Enter title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter amount:");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("Enter Month 1-12:");
            string read= Console.ReadLine();
            string month = GetMonthName(read);  // call Method to get the Name of Month from Number

            items.Add(new MoneyItem { Type = type, Title = title, Amount = amount, Month = month });
            Console.WriteLine(" added " + type + "  successfully!");
            Console.WriteLine("Press any key return to Main menue");
            Console.ReadKey();             // Pause to display the message before clearing the console
        }

     // To show all the list,  by Income or Expense
     public void Display()
          {

            string showChoice = Console.ReadLine();
              switch (showChoice)
              {
                  case "1":
                      displayByChoice();
                      break;
                  case "2":
                      DisplayIncome();

                      break;
                  case "3":
                      DisplayExpense();

                      break;
                  case "4":
                      return; // Back to the main menu
                  default:
                      Console.WriteLine("Invalid choice. Please try again.");
                      break;
              }
          }
       // make choices which sorted list to display
     public void displayByChoice()
        {
            sortChoices();
            
            string showChoice = Console.ReadLine();
            switch (showChoice)
            {
                case "1":
                    sortByTitle();
                    break;
                case "2":
                    sortByAmount();
                    break;
                case "3":
                    sortByMonth();
                    break;

                case "4":
                    return; // Back to the main menu
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
      // Method to sort the list by Title Asceding or Descending
     public void sortByTitle()
        {
            sort();
            string sortChoice = Console.ReadLine();

            switch (sortChoice)
            {
                case "1":
                    items = items.OrderBy(item => item.Title).ToList();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("List sort by Title Ascending");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    items = items.OrderByDescending(item => item.Title).ToList();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("List sort by Title Descending");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "3":
                    return; // Back to the main menu
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
            }

            printList(items);
          
            
        }
        // Method to sort the list by Month Asceding or Descending
     public void sortByMonth()
        {
            sort();
            string sortChoice = Console.ReadLine();

            switch (sortChoice)
            {
                case "1":
                    items = items.OrderBy(item => item.Month).ToList();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("List sort by Month Ascending");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    items = items.OrderByDescending(item => item.Month).ToList();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("List sort by Month Descending");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "3":
                    return; // Back to the main menu
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
            }
            Console.WriteLine(" List sorted By Month");
            printList(items);

           
        }
        // Method to sort the list by Amount Asceding or Descending
     public void sortByAmount()
        {
            sort();
            string sortChoice = Console.ReadLine();

            switch (sortChoice)
            {
                case "1":
                    items = items.OrderBy(item => item.Amount).ToList();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("List sort by Amount Ascending");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    items = items.OrderByDescending(item => item.Amount).ToList();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("List sort by Amount Ascending"); 
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "3":
                    return; // Back to the main menu
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
            }
            Console.WriteLine(" List sorted By Month");
            printList(items);
            
        }
    
    
        //Method to display List of Income
    public void DisplayIncome()
    {
        List<MoneyItem> itemsIncome = items.Where(item => item.Type.ToLower() == "Income".ToLower()).ToList();
        printList(itemsIncome);
         
    }

    
        //Method to display List of Expense 
    public void DisplayExpense()
    {

        List<MoneyItem> itemsExpense = items.Where(item => item.Type.ToLower().Contains("Expense".ToLower())).ToList();
            printList(itemsExpense);
        
    }
     
        // Method to print any kind of the list
     public void printList(List<MoneyItem> list)
        {
            Console.WriteLine("Type".PadRight(15) + "Title".PadRight(15) + "Amount".PadRight(15) + "Month".PadRight(15));
            Console.WriteLine("--------------------------------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item.Type.PadRight(15) + item.Title.PadRight(15) + item.Amount.ToString().PadRight(15) + item.Month.PadRight(15));
            }
            Console.WriteLine("Press any key to return to the main Menu");
            Console.ReadKey(); // Pause to display the items before clearing the console
        }
     
        // Method to choose between Edite item or Remove
     public void Edit()
    {
          
        string editRemoveChoice = Console.ReadLine();

        switch (editRemoveChoice)
        {
            case "1":
                EditItem();
                break;
            case "2":
                RemoveItem();
                break;
            case "3":
                return; // Back to the main menu
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

    } 
      
        // Edite item by enter title for the item to change 
     public void EditItem()
        {
            Console.WriteLine("Enter the title of the item you want to edit:");
            string titleToEdit = Console.ReadLine().ToLower();
      
            MoneyItem itemToEdit = items.Find(item => item.Title.ToLower() == titleToEdit);


            if (itemToEdit == null)
            {
                Console.WriteLine("Item not found.");
                //Console.ReadKey();
                return;
            }

            Console.WriteLine("Enter new title (press Enter to keep the current title):");
            string newTitle = Console.ReadLine();
            if (!string.IsNullOrEmpty(newTitle))
            {
                itemToEdit.Title = newTitle;
            }

            Console.WriteLine("Enter new amount (press Enter to keep the current amount):");
            string newAmountStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(newAmountStr))
            {

                double newAmount;
                if (double.TryParse(newAmountStr, out newAmount))
                {
                    itemToEdit.Amount = newAmount;
                }
                else
                {
                    Console.WriteLine("Invalid input. Amount not changed.");
                }
            }

            Console.WriteLine("Enter new month (press Enter to keep the current month):");
            
            string newMonth = Console.ReadLine();
            if (!string.IsNullOrEmpty(newMonth))
            {
                itemToEdit.Month = GetMonthName(newMonth);
            
; 
            }

            Console.WriteLine("Item edited successfully!");
            Console.WriteLine("Press any key to return to the main Menu");
            Console.ReadKey(); // Pause to display the message before clearing the console
        }
     
        // Remove item by enter which title that item 
     public void RemoveItem()
        {
            Console.WriteLine("Enter the title of the item you want to remove:");
            string titleToRemove = Console.ReadLine().ToLower();

            MoneyItem itemToRemove = items.Find(item => item.Title.ToLower() == titleToRemove);

            if (itemToRemove == null)
            {
                Console.WriteLine("Item not found.");
                Console.ReadKey();
                return;
            }

            items.Remove(itemToRemove);

            Console.WriteLine("Item removed successfully!");
            Console.WriteLine("Press any key to return to the main Menu");
            Console.ReadKey(); // Pause to display the message before clearing the console

        }
     
        // load list of item from file
     public void load()
        {
           
            string filePath = @"C:\Users\jaka1374\source\repos\20131030\projectTrackMoney\money_data.txt";
            if (File.Exists(filePath))
                 {
                     List<string> lines = File.ReadAllLines(filePath).ToList();
                     foreach (var line in lines)
                     {
                         string[] entries = line.Split(',');
                         MoneyItem newMoneyItem = new MoneyItem();
                         newMoneyItem.Type = entries[0];
                         newMoneyItem.Title = entries[1];
                         newMoneyItem.Amount = double.Parse(entries[2]);
                         newMoneyItem.Month = entries[3];
                         items.Add(newMoneyItem);
                     }


            }



        }
    
        // save all item into file and quite
     public void SaveData()
        {
            string filePath = @"C:\Users\jaka1374\source\repos\20131030\projectTrackMoney\money_data.txt";

            
            if (File.Exists(filePath))
            {
                List<string> output = new List<string>();
                foreach (var item in items)
                {

                    string line = (item.Type + "," + item.Title + "," + item.Amount + "," + item.Month);
                   
                    output.Add(line);
                }

                File.WriteAllLines(filePath, output);

                Console.WriteLine("Data saved successfully!");

            }
        }


        //Methode to take a number from user and convert it to the month name
        public string GetMonthName(string read)
        {
            int monthNumber;

            while (true)
            {
                if (!int.TryParse(read, out monthNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number between (1-12).");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (monthNumber < 1 || monthNumber > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number between (1-12).");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    DateTime monthDate = new DateTime(2000, monthNumber, 1); // Using a dummy year (2000)
                    string monthName = monthDate.ToString("MMMM");
                    return monthName;
                }

                // Prompt the user to re-enter the value
                Console.WriteLine("Please re-enter the month number between 1-12");
                read = Console.ReadLine();
            }
        }
        // Calculate and return the total Balance 
        public double CalculateBalance()
        {
            return items.Sum(item => item.Amount);
        }
   
    }
   
}
