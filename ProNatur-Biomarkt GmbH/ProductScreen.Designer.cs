
namespace ProNatur_Biomarkt_GmbH
{
    partial class ProductScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Marke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Preis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Kategorie = new System.Windows.Forms.ComboBox();
            this.btn_speichern = new System.Windows.Forms.Button();
            this.btn_bearbeiten = new System.Windows.Forms.Button();
            this.btn_leeren = new System.Windows.Forms.Button();
            this.btn_loeschen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(63, 8);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(167, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Marke
            // 
            this.tb_Marke.Location = new System.Drawing.Point(63, 32);
            this.tb_Marke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Marke.Name = "tb_Marke";
            this.tb_Marke.Size = new System.Drawing.Size(103, 20);
            this.tb_Marke.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie";
            // 
            // tb_Preis
            // 
            this.tb_Preis.Location = new System.Drawing.Point(63, 81);
            this.tb_Preis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Preis.Name = "tb_Preis";
            this.tb_Preis.Size = new System.Drawing.Size(81, 20);
            this.tb_Preis.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            // 
            // cb_Kategorie
            // 
            this.cb_Kategorie.FormattingEnabled = true;
            this.cb_Kategorie.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.cb_Kategorie.Location = new System.Drawing.Point(63, 56);
            this.cb_Kategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Kategorie.Name = "cb_Kategorie";
            this.cb_Kategorie.Size = new System.Drawing.Size(103, 21);
            this.cb_Kategorie.TabIndex = 3;
            // 
            // btn_speichern
            // 
            this.btn_speichern.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_speichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speichern.ForeColor = System.Drawing.Color.Black;
            this.btn_speichern.Location = new System.Drawing.Point(63, 109);
            this.btn_speichern.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(81, 27);
            this.btn_speichern.TabIndex = 9;
            this.btn_speichern.Text = "Speichern";
            this.btn_speichern.UseVisualStyleBackColor = false;
            this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
            // 
            // btn_bearbeiten
            // 
            this.btn_bearbeiten.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_bearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bearbeiten.ForeColor = System.Drawing.Color.Black;
            this.btn_bearbeiten.Location = new System.Drawing.Point(145, 109);
            this.btn_bearbeiten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(81, 27);
            this.btn_bearbeiten.TabIndex = 10;
            this.btn_bearbeiten.Text = "Bearbeiten";
            this.btn_bearbeiten.UseVisualStyleBackColor = false;
            this.btn_bearbeiten.Click += new System.EventHandler(this.btn_bearbeiten_Click);
            // 
            // btn_leeren
            // 
            this.btn_leeren.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_leeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leeren.ForeColor = System.Drawing.Color.Black;
            this.btn_leeren.Location = new System.Drawing.Point(227, 109);
            this.btn_leeren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_leeren.Name = "btn_leeren";
            this.btn_leeren.Size = new System.Drawing.Size(81, 27);
            this.btn_leeren.TabIndex = 11;
            this.btn_leeren.Text = "Felder leeren";
            this.btn_leeren.UseVisualStyleBackColor = false;
            this.btn_leeren.Click += new System.EventHandler(this.btn_leeren_Click);
            // 
            // btn_loeschen
            // 
            this.btn_loeschen.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_loeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loeschen.ForeColor = System.Drawing.Color.Black;
            this.btn_loeschen.Location = new System.Drawing.Point(309, 109);
            this.btn_loeschen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(81, 27);
            this.btn_loeschen.TabIndex = 12;
            this.btn_loeschen.Text = "Löschen";
            this.btn_loeschen.UseVisualStyleBackColor = false;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 270);
            this.dataGridView1.TabIndex = 13;
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_loeschen);
            this.Controls.Add(this.btn_leeren);
            this.Controls.Add(this.btn_bearbeiten);
            this.Controls.Add(this.btn_speichern);
            this.Controls.Add(this.cb_Kategorie);
            this.Controls.Add(this.tb_Preis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Marke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Marke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Preis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Kategorie;
        private System.Windows.Forms.Button btn_speichern;
        private System.Windows.Forms.Button btn_bearbeiten;
        private System.Windows.Forms.Button btn_leeren;
        private System.Windows.Forms.Button btn_loeschen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}