using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinoDB
{
    public partial class Saalid : Form
    {
        int i, j;
        Label[,] _arr;
        public Saalid(int i_, int j_)
        {
            InitializeComponent();
            _arr = new Label[i_, j_];
            this.Size = new Size(i_ * 51, j_ * 51);
            this.Text = "Ap_polo_kino";
            for (i = 0; i < i_; i++) 
            {
                for (j = 0; j < j_; j++)
                {
                    _arr[i, j] = new Label();
                    _arr[i, j].BackColor = Color.Green;
                    _arr[i, j].Text = " Koht" + (j + 1);//"Rida " + i +
                    _arr[i, j].Size = new Size(50, 50);
                    _arr[i, j].BorderStyle = BorderStyle.Fixed3D;
                    _arr[i, j].Location = new Point(j * 50 + 50, i * 50);
                    this.Controls.Add(_arr[i, j]);
                    _arr[i, j].Tag = new int[] { i, j };
                    _arr[i, j].Click += new System.EventHandler(Form1_Click);
                }
            }
        }

        private void Saalid_Load(object sender, EventArgs e)
        {

        }
    }
}
