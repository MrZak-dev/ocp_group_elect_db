using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace electrika
{
    public partial class Operations : Form
    {
        DataTable equipementData;
        public Operations()
        {
            InitializeComponent();
            
        }
        public void SqliteConnection() {
            //initialise the database
            SQLiteConnection connection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");
            connection.Open();
            Console.WriteLine(connection.State.ToString());
            //
            string sqlQuery = "SELECT e.id , e.designation, p.nom , s.nom , d.nom from equipement e ," +
                " departement d , station s , poste p where e.departement_id = d.id AND " +
                "d.poste_id = p.id AND p.station_id = s.id";
            // Command 
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = null;

            try {
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    string[] oneRow = { reader.GetInt32(0).ToString(), reader.GetString(1) , reader.GetString(2),
                    reader.GetString(4),reader.GetString(3)};
                    equipementData.Rows.Add(oneRow);
                    //equipement_grid.Rows.Add(oneRow);

                    if (!departementSelect.Items.Contains(reader.GetString(4))) {
                        departementSelect.Items.Add(reader.GetString(4));
                    }
                    if (!stationSelect.Items.Contains(reader.GetString(3))) {
                        stationSelect.Items.Add(reader.GetString(3));
                    }
                    if (!posteSelect.Items.Contains(reader.GetString(2))) {
                        posteSelect.Items.Add(reader.GetString(2));
                    }
                }; 
            }

            catch (Exception error) {
                Console.WriteLine(error.ToString());
            }
            finally {
                if (reader != null) reader.Close();
                connection.Close();
                equipement_grid.DataSource = equipementData;
            }

        }
        private void Operations_Load(object sender, EventArgs e)
        {
            //creating new data table for equipement data
            equipementData = new DataTable();
            equipementData.Columns.Add("id", typeof(string));
            equipementData.Columns.Add("designation", typeof(string));
            equipementData.Columns.Add("poste", typeof(string));
            equipementData.Columns.Add("departement", typeof(string));
            equipementData.Columns.Add("station", typeof(string));
            SqliteConnection();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(equipement_grid.SelectedCells[0].Value.ToString());//replace with operation form 
            string selectedEquipementId = equipement_grid.SelectedCells[0].Value.ToString();
            
            OperationsForms equipementOperationsForms = new OperationsForms(selectedEquipementId);
            equipementOperationsForms.Show();


        }

        private void StationSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipementData.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "station", stationSelect.Text);
        }

        private void FilterBox_TextChanged(object sender, EventArgs e)
        {
            equipementData.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "designation", filterBox.Text);
        }

        private void DepartementSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipementData.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "departement", departementSelect.Text);
        }

        private void PosteSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipementData.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "poste", posteSelect.Text);
        }
        //TODO : get selected row column id done 
    }
}
