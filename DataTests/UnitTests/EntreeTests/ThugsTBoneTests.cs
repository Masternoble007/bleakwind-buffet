/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            Thugs_T_Bone ttb = new Thugs_T_Bone();
            Assert.Equal(6.44, ttb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            Thugs_T_Bone ttb = new Thugs_T_Bone();
            uint temp = 982;
            Assert.Equal(temp, ttb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            Thugs_T_Bone ttb = new Thugs_T_Bone();
            Assert.Empty(ttb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            Thugs_T_Bone ttb = new Thugs_T_Bone();
            Assert.Equal("Thugs T-Bone", ttb.ToString());
        }
    }
}