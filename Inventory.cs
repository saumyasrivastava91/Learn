using System.Collections.Generic;

namespace ClassLibrary1
{
    /// <summary>
    /// Items in Inventory
    /// </summary>
    public static class Inventory
    {
        public static List<Item> InventoryList =>
            new List<Item>()
            {
                new Item()
                {
                    ItemToSell = "A",
                    MRP = 50
                },
                new Item()
                {
                    ItemToSell = "B",
                    MRP = 30
                },
                new Item()
                {
                    ItemToSell = "C",
                    MRP = 20
                },
                new Item()
                {
                    ItemToSell = "D",
                    MRP = 15
                },
            };
    }
}
