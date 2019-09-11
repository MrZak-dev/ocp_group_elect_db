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
    public partial class PosteAdd : Form
    {
        private SQLiteConnection sqliteConnection;
        public PosteAdd()
        {
            InitializeComponent();
        }

        private void PosteAdd_Load(object sender, EventArgs e)
        {
            //sqlite connection initialization
            sqliteConnection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");

            //Departement list sqliteCommand,sql query and sqliteDataReader

            SQLiteDataReader stationsListSqlDataReader;
            string stationsListSqlQuery = "SELECT nom FROM station";

            SQLiteCommand departementsListSqlCommand = new SQLiteCommand(stationsListSqlQuery, sqliteConnection);
            //open the connection
            sqliteConnection.Open();

            try
            {
                stationsListSqlDataReader = departementsListSqlCommand.ExecuteReader();
                while (stationsListSqlDataReader.Read())
                {
                    posteStation.Items.Add(stationsListSqlDataReader.GetString(0));
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            finally
            {
                sqliteConnection.Close();
            }
        }

        private void PosteAddBtn_Click(object sender, EventArgs e)
        {
            string posteNameText = posteName.Text;
            string posteDescriptionText = posteDescription.Text;
            string posteStationText = posteStation.Text;

            //new poste add query
            string posteAddQuery = "INSERT INTO poste(nom,description,station_id) " +
                "VALUES('"+posteNameText+"','"+posteDescriptionText+"',(SELECT id FROM station WHERE nom='"+posteStationText+"'))";
            //poste add command
            SQLiteCommand posteAddCmd = new SQLiteCommand(posteAddQuery, sqliteConnection);
            sqliteConnection.Open();

            try {
                posteAddCmd.ExecuteNonQuery();
            } catch (Exception error) {
                Console.WriteLine(error.ToString());
            } finally {
                sqliteConnection.Close();
                posteName.Clear();
                posteDescription.Clear();
                MessageBox.Show("PosteAdd Add");
            }
        }
    }
}
