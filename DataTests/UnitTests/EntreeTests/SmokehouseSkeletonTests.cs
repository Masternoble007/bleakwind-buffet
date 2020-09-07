/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            uint temp = 602;
            Assert.Equal(temp, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;
            if (includeSausage == false || includeEgg == false || includeHashbrowns == false || includePancake == false)
            {
                if (!includeSausage) Assert.Contains("Hold the sausage.", ss.SpecialInstructions);
                if (!includeEgg) Assert.Contains("Hold the eggs.", ss.SpecialInstructions);
                if (!includeHashbrowns) Assert.Contains("Hold the hashbrowns.", ss.SpecialInstructions);
                if (!includePancake) Assert.Contains("Hold the pancake.", ss.SpecialInstructions);
            }
            else Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Smokehouse_Skeleton ss = new Smokehouse_Skeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }
    }
}