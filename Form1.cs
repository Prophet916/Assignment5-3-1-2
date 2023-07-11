using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_3_1_2
{
    public partial class Form1 : Form
    {
        private Checkout checkout = new Checkout();
        List<string> runningTotal = new List<string>();
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void HandleGroceryItemClick(string itemName)
        {
            GroceryItem item = checkout.GroceryItems.First(g => g.Name == itemName);

            decimal weight = 0;
            decimal price = 0;

            if (item.PricePerPound > 0)
            {
                Random random = new Random();
                weight = (decimal)random.Next(100, 501) / 100; // Generates a random weight between 1 and 5 pounds
                price = weight * item.PricePerPound;

                runningTotal.Add($"{itemName}, {weight:F2} lbs: ${price:F2}"); // Add item details to the running total list
                MessageBox.Show($"Price for {weight:F2} lbs of {itemName}: ${price:F2}");
            }
            else
            {
                price = item.Price;
                runningTotal.Add($"{itemName}: ${price:F2}"); // Add item details to the running total list
            }

            runningTotalLabel.Text = "Running Total:\n" + string.Join("\n", runningTotal);

            total += price; // Update the total amount
            totalLabel.Text = $"Total: ${total:F2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAmmo_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Ammo");
        }

        private void btnDonut_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Donut");
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Medical");
        }

        private void btnBanana_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Banana");
        }

        private void btnApple_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Apple");
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Orange");
        }

        private void btnPeach_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Peach");
        }

        private void btnPotion_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Potion");
        }

        private void btnTNT_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("TNT");
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Meat");
        }

        private void btnArmor_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Armor");
        }

        private void btnBomb_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Bomb");
        }

        private void btnGrenade_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Grenade");
        }

        private void btnGun_Click(object sender, EventArgs e)
        {
            HandleGroceryItemClick("Gun");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
