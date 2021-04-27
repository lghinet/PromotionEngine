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

        [Fact]
        public void RunEngineScenario1()
        {
            //arrange
            var engine = new SimpleEngine<CartModel>();
            engine.AddPromotion(new NItemsFixedPrice("A", 3, 130));
            engine.AddPromotion(new NItemsFixedPrice("B", 2, 45));
            engine.AddPromotion(new TwoItemsFixedPrice("C", "D", 30));

            var cart = new CartModel
            {
                Items = new()
                {
                    new("A", 5, 50),
                    new("B", 5, 30),
                    new("C", 1, 20),
                }
            };

            //act 
            var result = engine.Run(cart);

            // Assert
            result.TotalValue.Should().Be(370);
        }
    }
}