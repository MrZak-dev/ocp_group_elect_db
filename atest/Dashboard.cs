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
        SQLiteCommand panneCmd;
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

            //panne history query
            string panneQuery = "SELECT count(id) , date FROM panne WHERE en_panne = 'oui' GROUP BY date ";
            panneCmd = new SQLiteCommand(panneQuery, sqliteConnection); 
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SQLiteDataReader dataReader = null;
            SQLiteDataReader panneReader = null;
            panneReader = panneCmd.ExecuteReader();
            dataReader = sqliteCommand.ExecuteReader();
            try
            {
                while (dataReader.Read())
                {
                    equipement_label.Text = dataReader.GetInt32(0).ToString();
                    departement_label.Text = dataReader.GetInt32(1).ToString();
                    panne_label.Text = dataReader.GetInt32(2).ToString();
                }

                while (panneReader.Read()) {
                    chart1.Series["Pannes"].Points.AddXY(panneReader.GetDateTime(1).ToString("dd/MMM"), panneReader.GetInt32(0));
                    Console.WriteLine(panneReader.GetDateTime(1).ToString("dd/MMM"));
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            finally {
                if (dataReader != null) dataReader.Close();
                if (panneReader != null) panneReader.Close();
                sqliteConnection.Close();
            }
            
            /*chart1.Series["Pannes"].Points.AddXY(2, 5);
            chart1.Series["Pannes"].Points.AddXY(3, 10);
            chart1.Series["Pannes"].Points.AddXY("15-aug", 10);*/

        }
    }
}
