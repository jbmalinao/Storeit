﻿namespace Store_It_App
{
    public class SaleItem
    {

        private string productName;
        private decimal productCost;
        private int productQuantity;

        // properties
        public string ProductName
        {
            get => this.productName;
            set => this.productName = value;
        }
        public decimal ProductCost
        {
            get => this.productCost;
            set => this.productCost = value;
        }
        public int ProductQuantity
        {
            get => this.productQuantity;
            set => this.productQuantity = value;
        }


        public SaleItem(string productName, decimal productCost, int productQuantity)
        {
            this.productName = productName;
            this.productCost = productCost;
            this.productQuantity = productQuantity;
            this.tags = new HashSet<string>();
        }
        public void AddTag(string tag)
        {
            this.tags.Add(tag);
        }

        public void RemoveTag(string tag)
        {
            this.tags.Remove(tag);
        }

        public IReadOnlyList<string> Tags()
        {
            return this.tags.ToList().AsReadOnly();
        }

        public override string ToString()
        {
            return $"{this.productName}\nTotal Cost: {this.productCost * this.productQuantity}\n\tP{this.productCost} x {this.productQuantity}qty\nTags: {string.Join(", ", this.tags)}";
        }
    }
}