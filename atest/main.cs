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
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //creating a new summary panel
            Dashboard dashboardPanel = new Dashboard(); //we will pass data through constructure next time
            dashboardPanel.TopLevel = false;

            //clear the panel old controls content 
            panelsContainer.Controls.Clear();
            panelsContainer.Controls.Add(dashboardPanel);
            dashboardPanel.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //creating a new Search panel
            Search searchPanel = new Search(); //we will pass data through constructure next time
            searchPanel.TopLevel = false;

            //clear the panel old controls content 
            panelsContainer.Controls.Clear();
            panelsContainer.Controls.Add(searchPanel);
            searchPanel.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //creating a new Operations panel
            Operations operationsPanel = new Operations(); //we will pass data through constructure next time
            operationsPanel.TopLevel = false;

            //clear the panel old controls content 
            panelsContainer.Controls.Clear();
            panelsContainer.Controls.Add(operationsPanel);
            operationsPanel.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //creating a new Operations panel
            Pannes pannesPanel = new Pannes(); //we will pass data through constructure next time
            pannesPanel.TopLevel = false;

            //clear the panel old controls content 
            panelsContainer.Controls.Clear();
            panelsContainer.Controls.Add(pannesPanel);
            pannesPanel.Show();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X  - 392, Cursor.Position.Y - 20);
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //creating a new summary panel
            Dashboard dashboardPanel = new Dashboard(); //we will pass data through constructure next time
            dashboardPanel.TopLevel = false;

            //clear the panel old controls content 
            panelsContainer.Controls.Clear();
            panelsContainer.Controls.Add(dashboardPanel);
            dashboardPanel.Show();
        }
    }
}
