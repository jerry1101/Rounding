using System;
using Xunit;

namespace Rounding
{
    public class RoundingTest
    {
        [Fact]
        public void TestRoundToTheNearestHundredth()
        {
            Inventory inventory = new Inventory(10.323);
            IRoundingCommand command = new ToTheNearestHundredthRounder();
            Assert.Equal(10.32, 
                inventory.SetRounder(command)
                        .GetRoundedValue());

        }

        [Fact]
        public void TestRoundToTheNearestThoundsth()
        {
            Inventory inventory = new Inventory(10.3234);
            IRoundingCommand command = new ToTheNearestThoundsRounder();
            Assert.Equal(10.323, 
                inventory.SetRounder(command)
                        .GetRoundedValue());

        }
    }
}
