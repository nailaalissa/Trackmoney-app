using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTrackMoney
{
    public class MoneyItem
    {
        public MoneyItem()
        {
        }


        public MoneyItem(string type ,string title, double amount, string month)
        {
           Title = title;
            Amount = amount;
            Month = month;
            Type = type;
            
             
        }

        public string Title { get; set; }
        public double Amount { get; set; }
        public string Month { get; set; }
        public string Type { get; set; } // "Income" or "Expense"
    }
}
