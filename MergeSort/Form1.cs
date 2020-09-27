using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class Form1 : Form
    {
        List<Button> allButtons = new List<Button>(); 
        public Form1()
        {
            InitializeComponent();
        }
        int w = 15, l = 75;
        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (var item in lblArrayItems.Items)
            {
                Button btn = new Button();
                btn.Text = item.ToString();
                btn.Location = new Point(w, l);
                btn.Size = new Size(75, 25);
                btn.BackColor = Color.DarkCyan;
                btn.ForeColor = Color.White;

                this.panel1.Controls.Add(btn);
                allButtons.Add(btn);

                w += 85;
            }

            lblArrayItems.Dispose();
            lblArrayItems.Dispose();
            TextBox t= new TextBox();
            t.Text = "Result Show ";
            t.Location=new Point();

            this.panel2.Controls.Add(t);
        }
    }
}
