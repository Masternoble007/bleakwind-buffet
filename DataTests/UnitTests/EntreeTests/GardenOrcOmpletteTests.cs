/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            goo.Tomato = true;
            Assert.True(goo.Tomato);
            goo.Tomato = false;
            Assert.False(goo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            Assert.Equal(4.57, goo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            uint temp = 404;
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            Assert.Equal(temp, goo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;
            if (includeBroccoli == false || includeMushrooms == false || includeTomato == false || includeCheddar == false)
            {
                if (!includeBroccoli) Assert.Contains("Hold the broccoli.", goo.SpecialInstructions);
                if (!includeMushrooms) Assert.Contains("Hold the mushrooms.", goo.SpecialInstructions);
                if (!includeTomato) Assert.Contains("Hold the tomatoes.", goo.SpecialInstructions);
                if (!includeCheddar) Assert.Contains("Hold the cheddar.", goo.SpecialInstructions);
            }
            else Assert.Empty(goo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Garden_Orc_Omelette goo = new Garden_Orc_Omelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }
    }
}