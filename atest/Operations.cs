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
            string sqlQuery = "SELECT * from equipement";
            // Command 
            SQLiteCommand command = new SQLiteCommand(sqlQuery, connection);
            SQLiteDataReader reader = null;

            try {
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    string[] oneRow = { reader.GetInt32(0).ToString(), reader.GetString(1) , reader.GetString(2),
                    reader.GetString(3),reader.GetInt32(4).ToString()};
                    dataGridView1.Rows.Add(oneRow);
                }; 
            }

            catch (Exception error) {
                Console.WriteLine(error.ToString());
            }
            finally {
                if (reader != null) reader.Close();
                connection.Close();
            }

        }
        private void Operations_Load(object sender, EventArgs e)
        {
            SqliteConnection();
        }
    }
}
