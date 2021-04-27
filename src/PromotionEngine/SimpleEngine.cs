using PromotionEngine.Promotions;
using System.Collections.Generic;

namespace PromotionEngine
{
    /// <summary>
    /// a simple pipeline for running multiple promotions 
    /// </summary>
    /// <typeparam name="T"></typeparam>
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