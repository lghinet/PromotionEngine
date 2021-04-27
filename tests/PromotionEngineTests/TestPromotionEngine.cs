using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine;
using PromotionEngine.Promotions;
using Xunit;

namespace PromotionEngineTests
{
    public class TestPromotionEngine
    {
        private List<ItemPriceModel> _unitPrices = new()
        {
            new() {ItemCode = "A", UnitPrice = 50},
            new() {ItemCode = "B", UnitPrice = 30},
            new() {ItemCode = "C", UnitPrice = 20},
            new() {ItemCode = "D", UnitPrice = 10},
        };

        [Fact]
        public void RunEngineWithNoPromotions()
        {
            //arrange
            var engine = new SimpleEngine<CartModel>();
            engine.AddPromotion(new NItemsFixedPrice("A", 3, 130));
            engine.AddPromotion(new NItemsFixedPrice("A", 3, 130));

            //act 
            var cart = engine.Run(new CartModel());

            // Assert
            cart.Total.Should().Be(100);
        }
    }
}