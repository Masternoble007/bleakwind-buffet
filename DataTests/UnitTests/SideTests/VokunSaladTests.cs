﻿/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            Vokun_Salad vs = new Vokun_Salad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            Vokun_Salad vs = new Vokun_Salad();
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            Vokun_Salad vs = new Vokun_Salad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Vokun_Salad vs = new Vokun_Salad();
            Assert.Empty(vs.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            Vokun_Salad vs = new Vokun_Salad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            Vokun_Salad vs = new Vokun_Salad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            Vokun_Salad vs = new Vokun_Salad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToAbstractFooClass()
        {
            var bar = new Vokun_Salad();
            Assert.IsAssignableFrom<Side>(bar);
        }
    }
}