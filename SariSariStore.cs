using System;

﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace store
{
    public class SariSariStore
    {
       public List<Customer> Customers { get; set; }

    public List<Product> Products { get; set; }

    public List<Sale> Sales { get; set; }

    public SariSariStore()

    {

        Customers = new List<Customer>();

        Products = new List<Product>();

        Sales = new List<Sale>();

    }

    public void AddCustomer(Customer customer)

    {

        Customers.Add(customer);

    }

    public void AddProduct(Product product)

    {

        Products.Add(product);

    }

    public void RecordSale(Sale sale)

    {

        Sales.Add(sale);

    }

    public decimal CalculateTotalExpenses()

    {

        decimal totalExpenses = 0;

        foreach (Product product in Products)

        {

            totalExpenses += product.Cost;

        }

        return totalExpenses;

    }

    public decimal CalculateProfit(decimal totalExpenses)

    {

        decimal totalSales = 0;

        foreach (Sale sale in Sales)

        {

            totalSales += sale.GetTotalAmount();

        }

        decimal profit = totalSales - totalExpenses;

        return profit;
      
    }
}
