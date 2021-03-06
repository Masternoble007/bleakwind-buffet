﻿/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            Mad_Otar_Grits mog = new Mad_Otar_Grits();
            Assert.IsAssignableFrom<Side>(mog);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Mad_Otar_Grits mog = new Mad_Otar_Grits();
            Assert.Equal(Size.Small, mog.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Mad_Otar_Grits mog = new Mad_Otar_Grits();
            mog.Size = Size.Large;
            Assert.Equal(Size.Large, mog.Size);
            mog.Size = Size.Medium;
            Assert.Equal(Size.Medium, mog.Size);
            mog.Size = Size.Small;
            Assert.Equal(Size.Small, mog.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            Mad_Otar_Grits mog = new Mad_Otar_Grits();
            Assert.Empty(mog.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            Mad_Otar_Grits mog = new Mad_Otar_Grits();
            mog.Size = size;
            Assert.Equal(price, mog.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            Mad_Otar_Grits mog = new Mad_Otar_Grits();
            mog.Size = size;
            Assert.Equal(calories, mog.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Mad_Otar_Grits mog = new Mad_Otar_Grits();
            mog.Size = size;
            Assert.Equal(name, mog.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            var bar = new Mad_Otar_Grits();
            Assert.IsAssignableFrom<Side>(bar);
        }
    }
}