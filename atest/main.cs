﻿using System;
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
            Dashboard dashboardPanel = new Dashboard(); //we will pass data through constructure next time
            dashboardPanel.TopLevel = false;

            //clear the panel old controls content 
            panelsContainer.Controls.Clear();
            panelsContainer.Controls.Add(dashboardPanel);
            dashboardPanel.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //creating a new summary panel
            Search searchPanel = new Search(); //we will pass data through constructure next time
            searchPanel.TopLevel = false;

            //clear the panel old controls content 
            panelsContainer.Controls.Clear();
            panelsContainer.Controls.Add(searchPanel);
            searchPanel.Show();

        }
    }
}
