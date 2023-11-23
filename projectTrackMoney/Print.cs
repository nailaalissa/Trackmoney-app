using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTrackMoney
{
    public class Print
    {
     // this class contain all print methods  with coloring 
        public void mainChoices()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(">> Pick an Option");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.Write(") Add New Expense ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("/ ");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Income ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.Write(") Show All ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("/ ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("Expens(s) ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("/ ");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Income(s))");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White; Console.Write(") Edite Item ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(edite");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("/ ");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" remove)");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("4");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Save and Quite");
            
          
        }

        public void printAddchoices()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(">> Pick an Option");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Add New Income ");

            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Add New Expense ");

            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Back to Main Menu");

         
        }
        public void displayChoises()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Pick an Option");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Show All Items ");

            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Show List of Incomes");
           
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Show List of Expenses");


            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("4");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Back to Main Menu");

          
        }
        public void sortChoices()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" Pick an Option ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Sort List by Title");
            
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Sort List by Amount");

            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Sort List by Month");

            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("4");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") return to Main Menu");



        }

        public void sort()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") sorted ascending");

            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") sorted Descending");
            
        }
        public void printEdite()
        {
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Pick an Option");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Edit");

            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Remove");

            Console.ForegroundColor = ConsoleColor.Blue; Console.Write(">> ");
            Console.ForegroundColor = ConsoleColor.White; Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("3");
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(") Back to Main Menu ");
            
        }
    }

}
