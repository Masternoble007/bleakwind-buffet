using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            Warrior_Water ww = new Warrior_Water();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            Warrior_Water ww = new Warrior_Water();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            Warrior_Water ww = new Warrior_Water();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Warrior_Water ww = new Warrior_Water();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            Warrior_Water ww = new Warrior_Water();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (includeIce == false || includeLemon == true)
            {
                if (!includeIce) Assert.Contains("Hold ice.", ww.SpecialInstructions);
                if (includeLemon) Assert.Contains("Add lemon.", ww.SpecialInstructions);
            }
            else Assert.Empty(ww.SpecialInstructions);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            var bar = new Warrior_Water();
            Assert.IsAssignableFrom<Drink>(bar);
        }


    }
}
