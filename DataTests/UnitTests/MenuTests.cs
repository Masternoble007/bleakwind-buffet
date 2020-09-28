/*
 * Author: Steven Avila
 * Class: Menu.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {

        [Fact]
        public void WouldCollectAllSidesForMenu()
        {
            List<Entree> list = new List<Entree>();
            list.Add(new Briarheart_Burger());
            list.Add(new Double_Draugr());
            list.Add(new Garden_Orc_Omelette());
            list.Add(new Philly_Poacher());
            list.Add(new Smokehouse_Skeleton());
            list.Add(new Thalmor_Triple());
            list.Add(new Thugs_T_Bone());

            List<IOrderItem> temp = new List<IOrderItem>(Menu.Entrees());

            List<Entree> fromMenu = (List<Entree>)Menu.Entrees();
            //Assert.Collection(list, fromMenu);
        }



    }
}
