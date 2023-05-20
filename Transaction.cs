using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store
{
    public class Transaction

{

    public Customer Customer { get; set; }

    public TransactionType Type { get; set; }

    public decimal Amount { get; set; }

    public Transaction(Customer customer, TransactionType type, decimal amount)

    {

        Customer = customer;

        Type = type;

        Amount = amount;

    }

}
}
