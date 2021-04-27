using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine;
using Xunit;

namespace PromotionEngineTests
{
    public class TestPromotionEngine
    {
        private List<ItemPriceModel> _unitPrices = new()
        {
            new() {ItemCode = "A", Price = 50},
            new() {ItemCode = "B", Price = 30},
            new() {ItemCode = "C", Price = 20},
            new() {ItemCode = "D", Price = 10},
        };

        [Fact]
        public void RunEngineWithNoPromotions()
        {
            //arrange
           

            var items = new CartModel()
            {

              
            }

            //act 

            // Assert
        }
    }
}
