
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.produkteDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.produkteDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.tb_Name.Location = new System.Drawing.Point(94, 12);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(248, 26);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Marke
            // 
            this.tb_Marke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.tb_Marke.Location = new System.Drawing.Point(94, 49);
            this.tb_Marke.Name = "tb_Marke";
            this.tb_Marke.Size = new System.Drawing.Size(152, 26);
            this.tb_Marke.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie";
            // 
            // tb_Preis
            // 
            this.tb_Preis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.tb_Preis.Location = new System.Drawing.Point(94, 125);
            this.tb_Preis.Name = "tb_Preis";
            this.tb_Preis.Size = new System.Drawing.Size(120, 26);
            this.tb_Preis.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            // 
            // cb_Kategorie
            // 
            this.cb_Kategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.cb_Kategorie.FormattingEnabled = true;
            this.cb_Kategorie.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke",
            "Sonstige"});
            this.cb_Kategorie.Location = new System.Drawing.Point(94, 86);
            this.cb_Kategorie.Name = "cb_Kategorie";
            this.cb_Kategorie.Size = new System.Drawing.Size(152, 28);
            this.cb_Kategorie.TabIndex = 3;
            // 
            // btn_speichern
            // 
            this.btn_speichern.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_speichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_speichern.ForeColor = System.Drawing.Color.Black;
            this.btn_speichern.Location = new System.Drawing.Point(94, 168);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(122, 42);
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
            this.btn_bearbeiten.Location = new System.Drawing.Point(218, 168);
            this.btn_bearbeiten.Name = "btn_bearbeiten";
            this.btn_bearbeiten.Size = new System.Drawing.Size(122, 42);
            this.btn_bearbeiten.TabIndex = 10;
            this.btn_bearbeiten.Text = "Aktualisieren";
            this.btn_bearbeiten.UseVisualStyleBackColor = false;
            this.btn_bearbeiten.Click += new System.EventHandler(this.btn_bearbeiten_Click);
            // 
            // btn_leeren
            // 
            this.btn_leeren.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_leeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leeren.ForeColor = System.Drawing.Color.Black;
            this.btn_leeren.Location = new System.Drawing.Point(342, 168);
            this.btn_leeren.Name = "btn_leeren";
            this.btn_leeren.Size = new System.Drawing.Size(122, 42);
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
            this.btn_loeschen.Location = new System.Drawing.Point(466, 168);
            this.btn_loeschen.Name = "btn_loeschen";
            this.btn_loeschen.Size = new System.Drawing.Size(122, 42);
            this.btn_loeschen.TabIndex = 12;
            this.btn_loeschen.Text = "Löschen";
            this.btn_loeschen.UseVisualStyleBackColor = false;
            this.btn_loeschen.Click += new System.EventHandler(this.btn_loeschen_Click);
            // 
            // produkteDGV
            // 
            this.produkteDGV.AllowUserToAddRows = false;
            this.produkteDGV.AllowUserToDeleteRows = false;
            this.produkteDGV.AllowUserToResizeColumns = false;
            this.produkteDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.produkteDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.produkteDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produkteDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(219)))));
            this.produkteDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produkteDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.produkteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produkteDGV.Location = new System.Drawing.Point(94, 223);
            this.produkteDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.produkteDGV.MultiSelect = false;
            this.produkteDGV.Name = "produkteDGV";
            this.produkteDGV.ReadOnly = true;
            this.produkteDGV.RowHeadersVisible = false;
            this.produkteDGV.RowHeadersWidth = 62;
            this.produkteDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.produkteDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.produkteDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.produkteDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produkteDGV.Size = new System.Drawing.Size(1138, 415);
            this.produkteDGV.TabIndex = 13;
            this.produkteDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produkteDGV_CellContentClick);
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1326, 709);
            this.Controls.Add(this.produkteDGV);
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
            this.MaximizeBox = false;
            this.Name = "ProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            ((System.ComponentModel.ISupportInitialize)(this.produkteDGV)).EndInit();
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
        private System.Windows.Forms.DataGridView produkteDGV;
    }
}