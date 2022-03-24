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
    public partial class Form3 : Form
    {
        bool fl = true;
        Button btn;
        int n = 10;
        public Form3()
        {

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Panel pnContainer = new Panel();
            Controls.Add(pnContainer);
            
            int topPossion = 30;
            for(int i = 0; i <n;i++)
            {
                for(int j=0 ; j<n;j++)
                {
                    btn = new Button();
                    btn.Left = i*25;
                    btn.Top = j * 25;
                    btn.Size = new System.Drawing.Size(20, 20);
                    btn.Click += btn_Click;
                    pnContainer.Controls.Add(btn);
                }
            }
            pnContainer.Size = new Size(n * 25, n * 25); 
            Controls.Add(pnContainer);
        }
        void btn_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {

                if (item.GetType() == typeof(Button))
                {
                    item.Text = "X"; 
                }
            }

        }
    }
}
