using System;

namespace MockupVisProg.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public decimal Amount { get; set; }
    }
}
