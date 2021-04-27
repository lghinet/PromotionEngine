using System;
using System.Linq;

namespace PromotionEngine.Promotions
{
    /// <summary>
    /// TwoItemsFixedPrice is an IPromotion implementation
    /// when two items are added in the cart at the same time, a fixedPrice is used 
    /// </summary>
    public class TwoItemsFixedPrice : IPromotion<CartModel>
    {
        private readonly string _itemCode1;
        private readonly string _itemCode2;
        private readonly double _fixedPrice;

        public TwoItemsFixedPrice(string itemCode1, string itemCode2, double fixedPrice)
        {
            _itemCode1 = itemCode1;
            _itemCode2 = itemCode2;
            _fixedPrice = fixedPrice;
        }

        public CartModel Apply(CartModel cart)
        {
            var item1 = cart.Items.FirstOrDefault(x => x.ItemCode == _itemCode1);
            var item2 = cart.Items.FirstOrDefault(x => x.ItemCode == _itemCode2);
            if (item1 == null || item2 == null)
                return cart;

            var n = Math.Min(item1.Quantity, item2.Quantity);
            item1.Value = (item1.Quantity - n) * item1.UnitPrice;
            item2.Value = _fixedPrice * n + (item2.Quantity - n) * item2.UnitPrice;

            return cart;
        }
    }
}