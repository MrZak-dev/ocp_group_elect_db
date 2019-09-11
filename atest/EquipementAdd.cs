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
    public partial class EquipementAdd : Form
    {
        private SQLiteConnection sqliteConnection;
        public EquipementAdd()
        {
            InitializeComponent();
        }


        private void EquipementAdd_Load(object sender, EventArgs e)
        {
            //sqlite connection initialization
            sqliteConnection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");

            //Departement list sqliteCommand,sql query and sqliteDataReader
            
            SQLiteDataReader departementsListSqlDataReader;
            string departementsListSqlQuery = "SELECT nom FROM departement";

            SQLiteCommand departementsListSqlCommand = new SQLiteCommand(departementsListSqlQuery, sqliteConnection);
            //open the connection
            sqliteConnection.Open();

            try {
                departementsListSqlDataReader = departementsListSqlCommand.ExecuteReader();
                while (departementsListSqlDataReader.Read()) {
                    equipementDepartement.Items.Add(departementsListSqlDataReader.GetString(0));
                }

            } catch (Exception error) {
                Console.WriteLine(error.ToString());
            } finally {
                sqliteConnection.Close();
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string designation = equipementDesignation.Text;
            string nombre = equipementNumber.Text;
            string observation = equipementObservation.Text;
            string departement = equipementDepartement.Text;

            string newEquipementQuery = "INSERT INTO equipement(designation,nombre,observation,departement_id,panne) " +
                "VALUES('"+designation+"','"+nombre+"','"+observation+"',(SELECT id FROM departement WHERE nom='"+departement+"'),'non')";

            //open connection
            sqliteConnection.Open();
            SQLiteCommand newEquipementCmd = new SQLiteCommand(newEquipementQuery, sqliteConnection);

            try {
                newEquipementCmd.ExecuteNonQuery();
            } catch (Exception error) {
                Console.WriteLine(error.ToString());
            } finally {
                sqliteConnection.Close();
                //clear fields
                equipementDesignation.Clear();
                equipementNumber.Clear();
                equipementObservation.Clear();
                MessageBox.Show("Add");
                
            }

        }
    }
}
