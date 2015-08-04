using ProductLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> USStates = new List<Product>();
            USStates.Add(new Product() { ForeColor = Color.Red, Grouptype = "手機" });
            USStates.Add(new Product() { ForeColor = Color.Blue, Grouptype = "螢幕" });
            USStates.Add(new Product() { Name = "Iphone6", Price = 27000, ForeColor = Color.Red, Grouptype = "手機" });
            USStates.Add(new Product() { Name = "ViewSonic", Price = 5000, ForeColor = Color.Blue, Grouptype = "螢幕" });
            USStates.Add(new Product() { Name = "Iphone6s", Price = 29000, ForeColor = Color.Red, Grouptype = "手機" });
            USStates.Add(new Product() { Name = "Asus", Price = 3000, ForeColor = Color.Blue, Grouptype = "螢幕" });

            USStates = USStates.OrderBy(a => a.Grouptype).ToList(); //群組排序

            productList.DataSource = USStates;
        }
    }
}