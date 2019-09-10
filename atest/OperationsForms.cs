using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electrika
{
    public partial class OperationsForms : Form
    {
        //sqlite connection properties
        private SQLiteConnection sqliteConnection;

        private string equipementId;
        public OperationsForms()
        {
            InitializeComponent();
            
        }
        public OperationsForms(string equipementId) {
            InitializeComponent();
            this.equipementId = equipementId;

        }


        private void OperationsForms_Load(object sender, EventArgs e)
        {
            //equipement informations sqlitecommand , sql query and sqlitdatareader
            SQLiteCommand equipementinfoSqlCommand;
            SQLiteDataReader equipementSqlDataReader;
            string equipementInfoSqlQuery = "SELECT e.designation , e.nombre , e.observation , d.nom , e.panne " +
                "FROM equipement e , departement d WHERE e.departement_id = d.id AND e.id =" + this.equipementId; ;
            //Departement list sqliteCommand,sql query and sqliteDataReader
            SQLiteCommand departementsListSqlCommand;
            SQLiteDataReader departementsListSqlDataReader;
            string departementsListSqlQuery = "SELECT nom FROM departement";
            //sqlite connection initialization
            sqliteConnection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");
            //open the connection
            sqliteConnection.Open();

            //passing value to commands
            equipementinfoSqlCommand = new SQLiteCommand(equipementInfoSqlQuery, sqliteConnection);
            departementsListSqlCommand = new SQLiteCommand(departementsListSqlQuery, sqliteConnection);

            // executing commands
            try {
                equipementSqlDataReader = equipementinfoSqlCommand.ExecuteReader();
                departementsListSqlDataReader = departementsListSqlCommand.ExecuteReader();
                //getting select form items
                while (departementsListSqlDataReader.Read()) {
                    equipementDepartementSelect.Items.Add(departementsListSqlDataReader.GetString(0));
                }
                //getting equipement data
                while (equipementSqlDataReader.Read()) {
                    equipementDesignationText.Text = equipementSqlDataReader.GetString(0);
                    equipementNombreText.Text = equipementSqlDataReader.GetString(1);
                    equipementObservationText.Text = equipementSqlDataReader.GetString(2);

                    equipementDepartementSelect.Text = equipementSqlDataReader.GetString(3);

                    if (equipementSqlDataReader.GetString(4).Equals("oui")) {
                        panneCheck.Checked = true;
                    }
                    
                    
                }

               
            } catch (Exception error) {
                Console.WriteLine(error.ToString());
            } finally { }
            
            




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
