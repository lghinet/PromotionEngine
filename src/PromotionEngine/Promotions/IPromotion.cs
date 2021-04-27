namespace PromotionEngine.Promotions
{
    /// <summary>
    /// interface for adding different promotions implementations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPromotion<T>
    {
        public T Apply(T model);
    }
}