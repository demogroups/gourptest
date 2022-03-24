using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001190460_NguyenDacDat_Tuan01
{
    public partial class Form1 : Form
    {
        string[] foods = { "Grain", "Bread", "Beans", "Eggs", "Chicken", "Milk", "Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int topPosition = 10;
            foreach(string food in foods)
            {
                CheckBox checkbox = new CheckBox();
                checkbox.Left = 10;
                checkbox.Top = topPosition;
                topPosition += 30; 
                checkbox.Text = food;
                Controls.Add(checkbox);
            }
        }
    }
}
