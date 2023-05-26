using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace StoreIt
{
    public class Store
    {
        public List<Customer> Customers { get; set; }

        public List<Sale> Sales { get; set; }
        /*public Transaction transactions;*/
        public Store()

        {

            Customers = new List<Customer>();

            Sales = new List<Sale>();

        }

        public void AddCustomer(Customer customer)

        {

            Customers.Add(customer);

        }

        public void RecordSale(Sale sale)

        {

            Sales.Add(sale);

        }

        public void RecordDebtPayment(Customer customer, decimal amount)

        {

            customer.Debt -= amount;

        }

       /* public void AddTransaction(Transaction transaction)
        {

            Transaction.Add(transaction);

        }

        public decimal GetCustomerDebt(Customer customer)

        {

            decimal totalDebt = 0;

            foreach (Transaction transaction in Transaction)

            {

                if (transaction.Customer == customer && transaction.Type == TransactionType.Debt)

                {

                    totalDebt += transaction.Amount;

                }

                else if (transaction.Customer == customer && transaction.Type == TransactionType.Payment)

                {

                    totalDebt -= transaction.Amount;

                }

            }

            return totalDebt;

        }*/
    }
}
