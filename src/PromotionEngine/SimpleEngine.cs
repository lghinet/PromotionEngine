using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.Promotions;

namespace PromotionEngine
{
    public class SimpleEngine<T>
    {
        private readonly List<IPromotion<T>> _promotions = new ();
        public void AddPromotion(IPromotion<T> promotion)
        {
            _promotions.Add(promotion);
        }

        public T Run(T initialState)
        {
            var state = initialState;
            foreach (var promo in _promotions)
            {
                state = promo.Apply(state);
            }

            return state;
        }
    }
}