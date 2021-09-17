using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class ProductScreen : Form
    {

        //SQL-Verbindung
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\svenb\OneDrive\Dokumente\ProNaturBiomarkt.mdf;Integrated Security = True; Connect Timeout = 30");


        public ProductScreen()
        {
            InitializeComponent();

            //start
            //Daten aus Datenbank ziehen
            databaseConnection.Open();
            string query = "select * from produkte";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            produkteDGV.DataSource = dataSet.Tables[0];
            produkteDGV.Columns[0].Visible = false;



            databaseConnection.Close();




        }

        private void btn_speichern_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {

        }

        private void btn_leeren_Click(object sender, EventArgs e)
        {

        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {

        }
    }
}
