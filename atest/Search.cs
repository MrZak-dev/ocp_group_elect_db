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

            //hide image and shema btn
            technical_img.ImageLocation = "../../../res/logo-ocp.png";
            shema_pdf_btn.Visible = false;
            // nombre and observation set to 0 at beginning
            equipement_nmbr_label.Text = "0";
            equipement_observation_label.Text = "0";
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
            //equpement informations query
            sqlQuery = "SELECT  e.nombre , e.observation FROM  equipement e WHERE  e.id = " + searchedEquipementId[1];
            //fiche technique query 
            var technicalImgQuery = "SELECT f.id , f.shema_pdf  FROM fiche_technique f ," +
                " equipement e WHERE f.equipement_id = e.id and e.id =  " + searchedEquipementId[1];
            //fiche technique query command
            var technicalImgSqliteCommand = new SQLiteCommand(technicalImgQuery, sqliteConnection);
            //fiche technique reader
            SQLiteDataReader technicalImgReader = technicalImgSqliteCommand.ExecuteReader();

            sqliteCommand = new SQLiteCommand(sqlQuery, sqliteConnection);
            sqliteReader = sqliteCommand.ExecuteReader();
            try
            {
                while (sqliteReader.Read())
                {
                    if (sqliteReader.GetString(0) != "")
                    {
                        equipement_nmbr_label.Text = sqliteReader.GetString(0);
                    }
                    else {
                        equipement_nmbr_label.Text = "non-défini";
                    }

                    if (sqliteReader.GetString(1) != "") {
                        equipement_observation_label.Text = sqliteReader.GetString(1);
                    }
                    else {
                        equipement_observation_label.Text = "non-défini";
                    }
                }
                if (technicalImgReader.HasRows)
                {
                    while (technicalImgReader.Read())
                    {
                        //set technical image format image{number}.png
                        technical_img.ImageLocation = "../../../res/fiche_technique_img/image" +
                        technicalImgReader.GetInt32(0).ToString() + ".png";
                        shema_pdf_btn.Visible = true;
                    }
                }
                else {
                    technical_img.ImageLocation = "../../../res/logo-ocp.png";
                    shema_pdf_btn.Visible = false;
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
