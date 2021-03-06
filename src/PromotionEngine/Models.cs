using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class CartModel
    {
        public List<ItemModel> Items { set; get; }
        public double TotalValue => Items.Sum(x => x.Value);

    }

    public class ItemModel
    {
        public string ItemCode { get; }
        public int Quantity { get; }
        public double Value { set; get; }
        public double UnitPrice { get; }

        public ItemModel(string itemCode, int quantity, double unitPrice)
        {
            ItemCode = itemCode;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Value = UnitPrice * Quantity;
        }
    }
    
}