using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electrika
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //creating a new summary panel
            Summary summaryPanel = new Summary(); //we will pass data through constructure next time
            summaryPanel.TopLevel = false;

            //clear the panel old controls content 
            panelsContainer.Controls.Clear();
            panelsContainer.Controls.Add(summaryPanel);
            summaryPanel.Show();

        }
    }
}
