/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Bun = true;
            Assert.True(tt.Bun);
            tt.Bun = false;
            Assert.False(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Mustard = true;
            Assert.True(tt.Mustard);
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Pickle = true;
            Assert.True(tt.Pickle);
            tt.Pickle = false;
            Assert.False(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Cheese = true;
            Assert.True(tt.Cheese);
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Tomato = true;
            Assert.True(tt.Tomato);
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Mayo = true;
            Assert.True(tt.Mayo);
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Bacon = true;
            Assert.True(tt.Bacon);
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Egg = true;
            Assert.True(tt.Egg);
            tt.Egg = false;
            Assert.False(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            uint temp = 943;
            Assert.Equal(temp, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (includeBun == false | includeKetchup == false || includeMustard == false || includePickle == false
                || includeCheese == false || includeTomato == false || includeLettuce == false || includeMayo == false)
            {
                if (!includeBun) Assert.Contains("Hold the bun.", tt.SpecialInstructions);
                if (!includeKetchup) Assert.Contains("Hold the ketchup.", tt.SpecialInstructions);
                if (!includeMustard) Assert.Contains("Hold the mustard.", tt.SpecialInstructions);
                if (!includePickle) Assert.Contains("Hold the pickle.", tt.SpecialInstructions);
                if (!includeCheese) Assert.Contains("Hold the cheese.", tt.SpecialInstructions);
                if (!includeTomato) Assert.Contains("Hold the tomatoes.", tt.SpecialInstructions);
                if (!includeLettuce) Assert.Contains("Hold the lettuce.", tt.SpecialInstructions);
                if (!includeMayo) Assert.Contains("Hold the mayo.", tt.SpecialInstructions);
                if (!includeBacon) Assert.Contains("Hold the bacon.", tt.SpecialInstructions);
                if (!includeEgg) Assert.Contains("Hold the eggs.", tt.SpecialInstructions);
            }
            else Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Thalmor_Triple tt = new Thalmor_Triple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }
    }
}