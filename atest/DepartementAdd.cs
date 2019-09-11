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
    public partial class DepartementAdd : Form
    {
        private SQLiteConnection sqliteConnection;
        public DepartementAdd()
        {
            InitializeComponent();
        }

        private void DepartementAdd_Load(object sender, EventArgs e)
        {
            //sqlite connection initialization
            sqliteConnection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");

            //Departement list sqliteCommand,sql query and sqliteDataReader

            SQLiteDataReader postesListSqlDataReader;
            string postesListSqlQuery = "SELECT nom FROM poste";

            SQLiteCommand postesListSqlCommand = new SQLiteCommand(postesListSqlQuery, sqliteConnection);
            //open the connection
            sqliteConnection.Open();

            try
            {
                postesListSqlDataReader = postesListSqlCommand.ExecuteReader();
                while (postesListSqlDataReader.Read())
                {
                    departementPoste.Items.Add(postesListSqlDataReader.GetString(0));
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

        private void DepartementAddBtn_Click(object sender, EventArgs e)
        {
            string departementNameText = departementName.Text;
            string departementDescriptionText = departementDescription.Text;
            string departementPosteText = departementPoste.Text;

            //new poste add query
            string departementAddQuery = "INSERT INTO departement(nom,description,poste_id) " +
                "VALUES('" + departementNameText + "','" + departementDescriptionText + "'," +
                "(SELECT id FROM poste WHERE nom='" + departementPosteText + "'))";
            //poste add command
            SQLiteCommand departementAddCmd = new SQLiteCommand(departementAddQuery, sqliteConnection);
            sqliteConnection.Open();

            try
            {
                departementAddCmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            finally
            {
                sqliteConnection.Close();
                departementName.Clear();
                departementDescription.Clear();
                MessageBox.Show("Departement Add");
            }
        }
    }
}
