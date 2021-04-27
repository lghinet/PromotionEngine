using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Engine<T> where T : struct
    {
        private List<Func<T, T>> _promotions;

        public void AddPromotion(Func<T, T> promotion)
        {
            _promotions.Add(promotion);
        }

        public void Run(T model)
        {
            foreach (var promo in _promotions)
            {
                promo(model);
            }
        }
    }
}