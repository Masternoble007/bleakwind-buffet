/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {

        [Fact]
        public void ShouldBeADrink()
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            Assert.IsAssignableFrom<Drink>(aj);
        }


        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice.", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Aretino_Apple_Juice aj = new Aretino_Apple_Juice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());

        }
    }
}