/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint temp = 843;
            Double_Draugr dd = new Double_Draugr();
            Assert.Equal(temp, dd.Calories);

        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            Double_Draugr dd = new Double_Draugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;

            if (includeBun == false | includeKetchup == false || includeMustard == false || includePickle == false
                || includeCheese == false || includeTomato == false || includeLettuce == false || includeMayo == false)
            {
                if (!includeBun) Assert.Contains("Hold the bun.", dd.SpecialInstructions);
                if (!includeKetchup) Assert.Contains("Hold the ketchup.", dd.SpecialInstructions);
                if (!includeMustard) Assert.Contains("Hold the mustard.", dd.SpecialInstructions);
                if (!includePickle) Assert.Contains("Hold the pickle.", dd.SpecialInstructions);
                if (!includeCheese) Assert.Contains("Hold the cheese.", dd.SpecialInstructions);
                if (!includeTomato) Assert.Contains("Hold the tomatoes.", dd.SpecialInstructions);
                if (!includeLettuce) Assert.Contains("Hold the lettuce.", dd.SpecialInstructions);
                if (!includeMayo) Assert.Contains("Hold the mayo.", dd.SpecialInstructions);
            }
            else Assert.Empty(dd.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Double_Draugr dd = new Double_Draugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }
    }
}