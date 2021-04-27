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
        public string ItemCode { set; get; }
        public double Quantity { set; get; }
        public double Value { set; get; }
    }

    public class ItemPriceModel
    {
        public string ItemCode { set; get; }
        public double UnitPrice { set; get; }
    }
}