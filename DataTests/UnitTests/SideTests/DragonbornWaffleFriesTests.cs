/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            Dragonborn_Waffle_Fries dwf = new Dragonborn_Waffle_Fries();
            Assert.IsAssignableFrom<Side>(dwf);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Dragonborn_Waffle_Fries dwf = new Dragonborn_Waffle_Fries();
            Assert.Equal(Size.Small, dwf.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Dragonborn_Waffle_Fries dwf = new Dragonborn_Waffle_Fries();
            dwf.Size = Size.Large;
            Assert.Equal(Size.Large, dwf.Size);
            dwf.Size = Size.Medium;
            Assert.Equal(Size.Medium, dwf.Size);
            dwf.Size = Size.Small;
            Assert.Equal(Size.Small, dwf.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Dragonborn_Waffle_Fries dwf = new Dragonborn_Waffle_Fries();
            Assert.Empty(dwf.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            Dragonborn_Waffle_Fries dwf = new Dragonborn_Waffle_Fries();
            dwf.Size = size;
            Assert.Equal(price, dwf.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            Dragonborn_Waffle_Fries dwf = new Dragonborn_Waffle_Fries();
            dwf.Size = size;
            Assert.Equal(calories, dwf.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Dragonborn_Waffle_Fries dwf = new Dragonborn_Waffle_Fries();
            dwf.Size = size;
            Assert.Equal(name, dwf.ToString());
        }
    }
}