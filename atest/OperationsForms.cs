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
    public partial class OperationsForms : Form
    {
        private string equipementId;
        public OperationsForms()
        {
            InitializeComponent();
            
        }
        public OperationsForms(string equipementId) {
            InitializeComponent();
            this.equipementId = equipementId;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void OperationsForms_Load(object sender, EventArgs e)
        {
            //label1.Text = equipementId;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            EquipementAdd equipementAddPanel = new EquipementAdd();
            equipementAddPanel.TopLevel = false;

            //clear the panel old controls content 
            AddOperationsPanel.Controls.Clear();
            AddOperationsPanel.Controls.Add(equipementAddPanel);
            equipementAddPanel.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StationAdd stationAddPanel = new StationAdd();
            stationAddPanel.TopLevel = false;

            //clear the panel old controls content 
            AddOperationsPanel.Controls.Clear();
            AddOperationsPanel.Controls.Add(stationAddPanel);
            stationAddPanel.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PosteAdd posteAddPanel = new PosteAdd();
            posteAddPanel.TopLevel = false;

            //clear the panel old controls content 
            AddOperationsPanel.Controls.Clear();
            AddOperationsPanel.Controls.Add(posteAddPanel);
            posteAddPanel.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DepartementAdd departementAddPanel = new DepartementAdd();
            departementAddPanel.TopLevel = false;

            //clear the panel old controls content 
            AddOperationsPanel.Controls.Clear();
            AddOperationsPanel.Controls.Add(departementAddPanel);
            departementAddPanel.Show();
        }
    }
}
