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

            var cart = new CartModel
            {
                Items = new()
                {
                    new("A", 1, 50),
                    new("B", 1, 30),
                    new("C", 1, 20),
                }
            };

            //act 
            var result = engine.Run(cart);

            // Assert
            result.TotalValue.Should().Be(100);
        }
    }
}