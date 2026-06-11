using System;

namespace MockupVisProg.Models
{
    public class Expense : BaseModel
    {
        public int      ExpenseID    { get; set; }
        public DateTime Date         { get; set; }
        public string   Description  { get; set; }
        public int      CategoryID   { get; set; }
        public string   CategoryName { get; set; }
        public decimal  Amount       { get; set; }

        public override int GetID() => ExpenseID;

        public override string GetInfo()
        {
            return string.Format("[Expense] {0} - Rp{1:N0}", CategoryName, Amount);
        }
    }
}
