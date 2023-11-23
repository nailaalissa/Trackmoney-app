

using projectTrackMoney;

// create an object from MoneyMangment class 
MoneyItemsManager item= new MoneyItemsManager();
item.load();   // load items list from file 
Print print= new Print();


while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(">> ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Welcome to Money Tracking Application");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(">> ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("you have currently (");
    Console.ForegroundColor = ConsoleColor.Blue; Console.Write(item.CalculateBalance());  // print the total Balance
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" )Kr on your account.");
    Console.ForegroundColor = ConsoleColor.White;

    // Print the main Choices from class print
    print.mainChoices();
    
    string mainChoice = Console.ReadLine();

    switch (mainChoice)
    {
        case "1":
            print.printAddchoices();       // call method to print the choices
            item.AddItem();                // call add choices method from MoneyItemManger

            break;
        case "2":
            print.displayChoises();      // call method to print the choices
            item.Display();               // call show choices method from MoneyItemManger

            break;
        case "3":
            print.printEdite();            // call method to print the choices
            item.Edit();                   // call edit choices method from MoneyItemManger
            break;
        case "4":
          
           item.SaveData();                  // to save data into file  
            Environment.Exit(0);              // to close the program
            break;
        default:                            // error message if enter invaled value
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}


