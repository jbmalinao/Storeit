namespace Store_It_App
{
    public class SariSariStore
    {
        public List<Customer> Customers { get; set; }
        public List<Sale> Sales { get; set; }

        public SariSariStore()
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
    }