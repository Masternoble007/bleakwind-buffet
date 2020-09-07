/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            bb.Bun = true;
            Assert.True(bb.Bun);
            bb.Bun = false;
            Assert.False(bb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            bb.Mustard = true;
            Assert.True(bb.Mustard);
            bb.Mustard = false;
            Assert.False(bb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            bb.Pickle = true;
            Assert.True(bb.Pickle);
            bb.Pickle = false;
            Assert.False(bb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            bb.Cheese = true;
            Assert.True(bb.Cheese);
            bb.Cheese = false;
            Assert.False(bb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            Assert.Equal(6.32, bb.price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint temp = 743;
            Briarheart_Burger bb = new Briarheart_Burger();
            Assert.Equal(temp, bb.calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;
            if (includeBun == false | includeKetchup == false || includeMustard == false || includePickle == false || includeCheese == false)
            {
                if (!includeBun) Assert.Contains("Hold the bun.", bb.SpecialInstructions);
                if (!includeKetchup) Assert.Contains("Hold the ketchup.", bb.SpecialInstructions);
                if (!includeMustard) Assert.Contains("Hold the mustard.", bb.SpecialInstructions);
                if (!includePickle) Assert.Contains("Hold the pickle.", bb.SpecialInstructions);
                if (!includeCheese) Assert.Contains("Hold the cheese.", bb.SpecialInstructions);
            }
            else Assert.Empty(bb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Briarheart_Burger bb = new Briarheart_Burger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }
    }
}