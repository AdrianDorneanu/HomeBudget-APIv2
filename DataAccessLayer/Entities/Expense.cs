﻿namespace DataAccessLayer.Entities
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Buyer { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public DateTime DateOfBuying { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid BudgetId { get; set; }
        public Budget Budget { get; set; }
    }
}
