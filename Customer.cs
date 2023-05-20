namespace store
{
    public class Customer
    {
     public string Name { get; set; }

     public decimal Debt { get; set; }

     public Customer(string name)

    {

        Name = name;

        Debt = 0;

    }

    }
}
