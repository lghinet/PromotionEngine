using System.Linq;

namespace PromotionEngine.Promotions
{
    public class NItemsFixedPrice : IPromotion<CartModel>
    {
        private readonly string _itemCode;
        private readonly int _nTimes;
        private readonly double _fixedPrice;

        public NItemsFixedPrice(string itemCode, int nTimes, double fixedPrice)
        {
            _itemCode = itemCode;
            _nTimes = nTimes;
            _fixedPrice = fixedPrice;
        }

        public CartModel Apply(CartModel cart)
        {
            var item = cart.Items.FirstOrDefault(x => x.ItemCode == _itemCode);
            if (item == null)
                return cart;

            var n = item.Quantity / _nTimes;
            item.Value = n * _fixedPrice + (item.Quantity % _nTimes) * item.UnitPrice;

            return cart;
        }
    }
}