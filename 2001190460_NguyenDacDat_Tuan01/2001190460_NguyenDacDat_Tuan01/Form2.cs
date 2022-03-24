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
    public partial class Form2 : Form
    {
        string[] ns = {"banh","chao","com"};
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int topPosition = 10;
            foreach(string n in ns)
            {
                TextBox txt = new TextBox();
                txt.Left = 10;
                txt.Top = topPosition;
                topPosition +=30;
                txt.Text = n;
                Controls.Add(txt);
            }
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Top = 100;
            btn.Text = "BamNut";
            btn.Click += new System.EventHandler(bt_Click);

        }

        private void bt_Click(object sender, EventArgs e)
        {
            foreach(Control item in Controls )
            {
                if(item.GetType()==typeof(TextBox))
                {
                    item.Text = string.Empty;
                }
            }
        }

       
    }
}
