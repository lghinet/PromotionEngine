using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
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
            //engine.AddPromotion(new NItemsFixedPrice("A", 3, 130));
            //engine.AddPromotion(new NItemsFixedPrice("B", 2, 45));
            //engine.AddPromotion(new TwoItemsFixedPrice("C", "D", 30));

            var cart = new CartModel
            {
                Items = new()
                {
                    new() {ItemCode = "A", Quantity = 1, UnitPrice = 50},
                    new() {ItemCode = "B", Quantity = 1, UnitPrice = 30},
                    new() {ItemCode = "C", Quantity = 1, UnitPrice = 20}
                }
            };

            //act 
            var result = engine.Run(cart);

            // Assert
            result.TotalValue.Should().Be(100);
        }
    }
}