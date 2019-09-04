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
    public partial class Dashboard : Form
    {
        //sqlite connection properties
        private SQLiteConnection sqliteConnection;
        private SQLiteCommand sqliteCommand;
        private string sqlQuery;

        public Dashboard()
        {
            InitializeComponent();
            //sqlite connection initialization
            sqliteConnection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");
            //open the connection
            sqliteConnection.Open();
            sqlQuery = "select (SELECT count(*) FROM equipement) as equipement_nmbr , " +
                "(SELECT count(*) from departement) as departement_nmbr , " +
                "(SELECT count(*) from equipement WHERE panne ='oui' ) as panne_nmbr;";
            sqliteCommand = new SQLiteCommand(sqlQuery, sqliteConnection);
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SQLiteDataReader dataReader = null;
            dataReader = sqliteCommand.ExecuteReader();
            try
            {
                while (dataReader.Read())
                {
                    equipement_label.Text = dataReader.GetInt32(0).ToString();
                    departement_label.Text = dataReader.GetInt32(1).ToString();
                    panne_label.Text = dataReader.GetInt32(2).ToString();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            finally {
                if (dataReader != null) dataReader.Close();
                sqliteConnection.Close();
            }
        }
    }
}
