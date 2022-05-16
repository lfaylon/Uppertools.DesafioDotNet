using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppertools.DesafioDotNet.Expenses
{
    public class Expense : Entity<long>
    {
        public Expense()
        {
            DueDate = DateTime.Now;
            PaidOut = false;
        }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public decimal ExpenseAmount { get; set; }
        public bool PaidOut { get; set; }
        public decimal PaymentDate { get; set; }
        public decimal Fine { get; set; }
        public decimal Interest { get; set; }
        public decimal Discount { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}
