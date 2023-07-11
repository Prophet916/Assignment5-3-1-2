using Assignment5_3_1_2.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_3_1_2
{
    internal class Checkout
    {
        StringBuilder receiptBuilder = new StringBuilder();
        public List<GroceryItem> GroceryItems = new List<GroceryItem>()
        {
            new GroceryItem {Name = "Apple", PricePerPound = .89m, Icon = Properties.Resources.IconApple },
            new GroceryItem {Name = "Banana", PricePerPound = .75m, Icon = Properties.Resources.IconBanana},
            new GroceryItem {Name = "Orange", PricePerPound = 1.09M, Icon = Properties.Resources.IconOrange},
            new GroceryItem {Name = "Peach", PricePerPound = 1.25m, Icon = Properties.Resources.IconPeach},
            new GroceryItem {Name = "Donut", Price = 2.35m, Icon = Properties.Resources.IconDonut},
            new GroceryItem {Name = "Ammo", Price = 8.99m, Icon = Properties.Resources.IconAmmo3},
            new GroceryItem {Name = "Medical", Price = 102.56m, Icon = Properties.Resources.IconMedical},
            new GroceryItem {Name = "Gun", Price = 250.57m, Icon = Properties.Resources.IconGun},
            new GroceryItem {Name = "Potion", Price = 33.00m, Icon= Properties.Resources.IconPotion},
            new GroceryItem {Name = "Grenade", Price = 75m, Icon = Properties.Resources.IconGrenade},
            new GroceryItem {Name = "Bomb", Price = 199.99m, Icon= Properties.Resources.IconBomb},
            new GroceryItem {Name = "TNT", Price = 45m, Icon = Properties.Resources.IconTNT},
            new GroceryItem {Name = "Meat", PricePerPound = 6.99m, Icon = Properties.Resources.IconMeat},
            new GroceryItem {Name = "Armor", Price = 300m, Icon = Properties.Resources.IconArmor}
        };
    }

    public class GroceryItem
    {
        public string Name { get; set; }
        public decimal PricePerPound { get; set; }
        public decimal Price { get; set; }
        public Image Icon { get; set; }
    }
}
