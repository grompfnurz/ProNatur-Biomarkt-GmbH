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
        private int selektierteID;


        public ProductScreen()
        {
            InitializeComponent();
            ZeigeProdukte();
        }

        

        private void btn_speichern_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "" || tb_Marke.Text == "" || tb_Preis.Text == ""||cb_Kategorie.Text == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
                return;
            }
            string produktName = tb_Name.Text;
            string produktMarke = tb_Marke.Text;
            string produktKategorie = cb_Kategorie.Text;
            string produktPreis = tb_Preis.Text;
            string query = string.Format("insert into produkte values('{0}','{1}','{2}','{3}')", produktName, produktMarke, produktKategorie, produktPreis);
            queryAusfuehren(query);
            leereAlleFelder();
            ZeigeProdukte();
        }

        private void btn_bearbeiten_Click(object sender, EventArgs e)
        {
            if (selektierteID == 0)
            {
                MessageBox.Show("Bitte erst ein Produkt auswählen!");
                return;
            }

            string produktName = tb_Name.Text;
            string produktMarke = tb_Marke.Text;
            string produktKategorie = cb_Kategorie.Text;
            string produktPreis = tb_Preis.Text;
            string query = string.Format("update produkte set name='{0}',marke='{1}',kategorie='{2}',preis='{3}' where id={4}"
                , produktName, produktMarke, produktKategorie, produktPreis,selektierteID);
            queryAusfuehren(query);


            ZeigeProdukte();
        }

        private void btn_leeren_Click(object sender, EventArgs e)
        {
            leereAlleFelder();
        }

        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            if (selektierteID == 0)
            {
                MessageBox.Show("Bitte erst ein Produkt auswählen!");
            }
            string query = string.Format("delete from produkte where id = {0}",selektierteID);
            queryAusfuehren(query);
            leereAlleFelder();
            ZeigeProdukte();
        }
        private void queryAusfuehren(string query) {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }
        private void leereAlleFelder() {
            tb_Name.Text = "";
            tb_Marke.Text = "";
            tb_Preis.Text = "";
            cb_Kategorie.Text = "";
            cb_Kategorie.SelectedItem = null;
        }
        private void ZeigeProdukte() {
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

        private void produkteDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Name.Text = produkteDGV.SelectedRows[0].Cells[1].Value.ToString();
            tb_Marke.Text = produkteDGV.SelectedRows[0].Cells[2].Value.ToString();
            cb_Kategorie.Text = produkteDGV.SelectedRows[0].Cells[3].Value.ToString();
            tb_Preis.Text = produkteDGV.SelectedRows[0].Cells[4].Value.ToString();
            selektierteID = (int)produkteDGV.SelectedRows[0].Cells[0].Value;
        }
    }
}
