using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace electrika
{
    public partial class Search : Form
    {
        //sqlite connection properties
        private SQLiteConnection sqliteConnection;
        private SQLiteCommand sqliteCommand;
        private SQLiteDataReader sqliteReader;
        private string sqlQuery;
        private AutoCompleteStringCollection equipements_names;
        
        public Search()
        {
            InitializeComponent();
            //sqlite connection initialization
            sqliteConnection = new SQLiteConnection("Data Source=../../../res/database/laverie.db");
            //open the connection
            sqliteConnection.Open();
            sqlQuery = "SELECT e.designation , e.id , d.nom FROM equipement e , departement d where e.departement_id = d.id;";
            sqliteCommand = new SQLiteCommand(sqlQuery, sqliteConnection);
            equipements_names = new AutoCompleteStringCollection();
            try
            {
                sqliteReader = sqliteCommand.ExecuteReader();
                while (sqliteReader.Read())
                {
                    //add data to the autocomplete  variable so we can use it in text box
                    equipements_names.Add(sqliteReader.GetString(0) + " | " + sqliteReader.GetString(2) + " | " 
                        + sqliteReader.GetInt32(1).ToString() ); //format Equipement_name | departement_name | equpement_id
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            finally {
                if (sqliteReader != null) sqliteReader.Close();
                sqliteConnection.Close();
                sqlQuery = null;
                sqliteCommand = null;
            }
            
            
        }

        private void Search_Load(object sender, EventArgs e)
        {
            search_box.AutoCompleteCustomSource = equipements_names;
            search_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            search_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //get search box query 
            string searchQuery = search_box.Text;
            //split search query to get id
            string[] searchQueryWords = searchQuery.Split('|');
            string[] searchedEquipementId = searchQueryWords[2].Split(' '); // equipement real id

            //sqlite connection and command
            sqliteConnection.Open();
            sqlQuery = "SELECT f.id ,f.shema_pdf , e.nombre , e.observation FROM fiche_technique f , equipement e " +
                "WHERE f.equipement_id = e.id AND e.id = " + searchedEquipementId[1];
            sqliteCommand = new SQLiteCommand(sqlQuery, sqliteConnection);
            sqliteReader = sqliteCommand.ExecuteReader();
            try
            {
                if (sqliteReader.HasRows)
                {
                    while (sqliteReader.Read())
                    {
                        //set technical image format image{number}.png
                        technical_img.ImageLocation = "../../../res/fiche_technique_img/image" +
                        sqliteReader.GetInt32(0).ToString() + ".png";

                    }
                    technical_img.Visible = false;

                }
                else {
                    Console.WriteLine("noooo dataaaaaa");
                }
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            finally {
                sqliteConnection.Close();

            }


        }
    }
}
