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
    public partial class Pannes : Form
    {
        private DataTable pannesData;
        public Pannes()
        {
            InitializeComponent();
        }
        public void SqliteConnection()
        {
            //initialise the database
            SQLiteConnection connection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");
            connection.Open();
            Console.WriteLine(connection.State.ToString());
            //
            string sqlQuery = "SELECT e.designation , p.date , p.en_panne FROM " +
                "equipement e , panne p WHERE e.id = p.equipement_id ORDER BY p.date DESC";
            // Command 
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = null;

            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string operation;
                    if (reader.GetString(2).Equals("oui"))
                    {
                        operation = "Signalé une panne";
                    }
                    else {
                        operation = "Reparation";
                    }
                    string[] oneRow = { reader.GetString(0), reader.GetString(1) , operation};
                    pannesData.Rows.Add(oneRow);
                    //pannes_grid.Rows.Add(oneRow);
                };
            }

            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            finally
            {
                if (reader != null) reader.Close();
                connection.Close();
                pannesGrid.DataSource = pannesData;
            }

        }

        private void Pannes_Load(object sender, EventArgs e)
        {
            pannesData = new DataTable();
            pannesData.Columns.Add("Equipement", typeof(string));
            pannesData.Columns.Add("Date", typeof(string));
            pannesData.Columns.Add("Operation", typeof(string));
            SqliteConnection();
        }
    }
}
