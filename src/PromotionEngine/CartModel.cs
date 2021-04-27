using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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