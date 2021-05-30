namespace Milestone2
{
    public class InventoryItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public int ModelID { get; private set; }
        
        


        // Creates an Inventory Item
        public InventoryItem(string name, string description, int quantity, decimal price, int modelID)
        {
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = System.Math.Round(price, 2);
            this.ModelID = modelID;
        }
        // Checks to see if the item is out of stock.
        public bool OutOfStock()
        {
            return Quantity == 0;
        }

        // Checks to see if the amount requested is available
        private bool QuantityPurchasable(int requested)
        {
            return Quantity >= requested;
        }
        public bool PurchaseItem(int requested)
        {
            if (requested > 0 && !OutOfStock() && QuantityPurchasable(requested))
            {
                Quantity = Quantity - requested;
                return true;
            }
            return false;
        }
}
}