using System.Collections.Generic;

namespace PromotionEngine
{
    public class CartModel
    {
        public List<ItemModel> Items { set; get; }
        public double TotalPrice { set; get; }

    }

    public class ItemModel
    {
        public string ItemCode { set; get; }
        public double Quantity { set; get; }
    }

    public class ItemPriceModel
    {
        public string ItemCode { set; get; }
        public double Price { set; get; }
    }
}