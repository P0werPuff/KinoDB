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
    public partial class Start_app : Form
    {
        int i, j;
        ListBox listBox1;
        public Start_app()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==0)
            {
                i = 5; j = 5;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                i = 10; j = 10; 
            }
            else
            {
                i = 15; j = 15;
            }
            Saalid saalid = new Saalid(i, j);
            saalid.Show();
        }

        private void Start_app_Load(object sender, EventArgs e)
        {

        }
    }
}
