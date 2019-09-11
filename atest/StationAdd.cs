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
    public partial class StationAdd : Form
    {
        private SQLiteConnection sqliteConnection;
        public StationAdd()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

            string stationNameText = stationName.Text;
            string stationDescriptionText = stationDescription.Text;
            string stationAddQuery = "INSERT INTO station(nom,description) VALUES('"+stationNameText+"','"+stationDescriptionText+"')";

            SQLiteCommand stationAddCmd = new SQLiteCommand(stationAddQuery, sqliteConnection);
            //open connection
            sqliteConnection.Open();

            try {
                stationAddCmd.ExecuteNonQuery();
            } catch (Exception error) {
                Console.WriteLine(error.ToString());
            } finally {
                sqliteConnection.Close();
                stationName.Clear();
                stationDescription.Clear();
                MessageBox.Show("Station Add");
            }

        }

        private void StationAdd_Load(object sender, EventArgs e)
        {
            //sqlite connection initialization
            sqliteConnection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");
        }
    }
}
