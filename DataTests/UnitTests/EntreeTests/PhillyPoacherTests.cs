/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            Philly_Poacher pp = new Philly_Poacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            Philly_Poacher pp = new Philly_Poacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            Philly_Poacher pp = new Philly_Poacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            Philly_Poacher pp = new Philly_Poacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            Philly_Poacher pp = new Philly_Poacher();
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            Philly_Poacher pp = new Philly_Poacher();
            pp.Onion = true;
            Assert.True(pp.Onion);
            pp.Onion = false;
            Assert.False(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            Philly_Poacher pp = new Philly_Poacher();
            pp.Roll = true;
            Assert.True(pp.Roll);
            pp.Roll = false;
            Assert.False(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Philly_Poacher pp = new Philly_Poacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint temp = 784;
            Philly_Poacher pp = new Philly_Poacher();
            Assert.Equal(temp, pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            Philly_Poacher pp = new Philly_Poacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;
            if (includeSirloin == false || includeOnion == false || includeRoll == false)
            {
                if (!includeSirloin) Assert.Contains("Hold the sirloin.", pp.SpecialInstructions);
                if (!includeOnion) Assert.Contains("Hold the onions.", pp.SpecialInstructions);
                if (!includeRoll) Assert.Contains("Hold the rolls.", pp.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Philly_Poacher pp = new Philly_Poacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }
    }
}