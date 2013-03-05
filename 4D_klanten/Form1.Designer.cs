namespace _4D_klanten
{
    partial class FBeheerKlanten
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
            this.imgTop = new System.Windows.Forms.PictureBox();
            this.imgBot = new System.Windows.Forms.PictureBox();
            this.brKlanten = new System.Windows.Forms.DataGridView();
            this.klantenid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btwnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reknr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fraDetails = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbLimiet = new System.Windows.Forms.RadioButton();
            this.rbAlle = new System.Windows.Forms.RadioButton();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnClearReknr = new System.Windows.Forms.Button();
            this.txtReknr = new System.Windows.Forms.TextBox();
            this.lblReknr = new System.Windows.Forms.Label();
            this.btnClearDatum = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnClearBtw = new System.Windows.Forms.Button();
            this.btnClearContact = new System.Windows.Forms.Button();
            this.btnClearLocatie = new System.Windows.Forms.Button();
            this.btnClearNaam = new System.Windows.Forms.Button();
            this.btnClearNr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBtw = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtNr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brKlanten)).BeginInit();
            this.fraDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgTop
            // 
            this.imgTop.Location = new System.Drawing.Point(0, 0);
            this.imgTop.Name = "imgTop";
            this.imgTop.Size = new System.Drawing.Size(1054, 60);
            this.imgTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTop.TabIndex = 0;
            this.imgTop.TabStop = false;
            // 
            // imgBot
            // 
            this.imgBot.Location = new System.Drawing.Point(0, 592);
            this.imgBot.Name = "imgBot";
            this.imgBot.Size = new System.Drawing.Size(1054, 60);
            this.imgBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBot.TabIndex = 2;
            this.imgBot.TabStop = false;
            // 
            // brKlanten
            // 
            this.brKlanten.AllowUserToAddRows = false;
            this.brKlanten.AllowUserToDeleteRows = false;
            this.brKlanten.AllowUserToOrderColumns = true;
            this.brKlanten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brKlanten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klantenid,
            this.naam,
            this.email,
            this.btwnr,
            this.reknr});
            this.brKlanten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.brKlanten.Location = new System.Drawing.Point(0, 228);
            this.brKlanten.MultiSelect = false;
            this.brKlanten.Name = "brKlanten";
            this.brKlanten.ReadOnly = true;
            this.brKlanten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brKlanten.Size = new System.Drawing.Size(1054, 358);
            this.brKlanten.TabIndex = 3;
            this.brKlanten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brKlanten_CellDoubleClick);
            // 
            // klantenid
            // 
            this.klantenid.Frozen = true;
            this.klantenid.HeaderText = "ID";
            this.klantenid.Name = "klantenid";
            this.klantenid.ReadOnly = true;
            this.klantenid.Width = 50;
            // 
            // naam
            // 
            this.naam.Frozen = true;
            this.naam.HeaderText = "Naam";
            this.naam.Name = "naam";
            this.naam.ReadOnly = true;
            this.naam.Width = 300;
            // 
            // email
            // 
            this.email.Frozen = true;
            this.email.HeaderText = "Contact";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 300;
            // 
            // btwnr
            // 
            this.btwnr.Frozen = true;
            this.btwnr.HeaderText = "Btw";
            this.btwnr.Name = "btwnr";
            this.btwnr.ReadOnly = true;
            this.btwnr.Width = 200;
            // 
            // reknr
            // 
            this.reknr.Frozen = true;
            this.reknr.HeaderText = "Reknr";
            this.reknr.Name = "reknr";
            this.reknr.ReadOnly = true;
            this.reknr.Width = 200;
            // 
            // fraDetails
            // 
            this.fraDetails.Controls.Add(this.panel3);
            this.fraDetails.Controls.Add(this.pnlSearch);
            this.fraDetails.Controls.Add(this.pnlOptions);
            this.fraDetails.Location = new System.Drawing.Point(0, 66);
            this.fraDetails.Name = "fraDetails";
            this.fraDetails.Size = new System.Drawing.Size(1054, 156);
            this.fraDetails.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imgLogo);
            this.panel3.Location = new System.Drawing.Point(858, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 150);
            this.panel3.TabIndex = 17;
            // 
            // imgLogo
            // 
            this.imgLogo.Location = new System.Drawing.Point(3, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(187, 144);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.rbLimiet);
            this.pnlSearch.Controls.Add(this.rbAlle);
            this.pnlSearch.Controls.Add(this.txtAantal);
            this.pnlSearch.Location = new System.Drawing.Point(542, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(310, 150);
            this.pnlSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(215, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 46);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbLimiet
            // 
            this.rbLimiet.AutoSize = true;
            this.rbLimiet.Location = new System.Drawing.Point(26, 51);
            this.rbLimiet.Name = "rbLimiet";
            this.rbLimiet.Size = new System.Drawing.Size(183, 17);
            this.rbLimiet.TabIndex = 4;
            this.rbLimiet.TabStop = true;
            this.rbLimiet.Text = "Aantal zoekresultaten weergeven";
            this.rbLimiet.UseVisualStyleBackColor = true;
            // 
            // rbAlle
            // 
            this.rbAlle.AutoSize = true;
            this.rbAlle.Location = new System.Drawing.Point(26, 28);
            this.rbAlle.Name = "rbAlle";
            this.rbAlle.Size = new System.Drawing.Size(170, 17);
            this.rbAlle.TabIndex = 3;
            this.rbAlle.TabStop = true;
            this.rbAlle.Text = "Alle zoekresultaten weergeven";
            this.rbAlle.UseVisualStyleBackColor = true;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(215, 51);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(73, 20);
            this.txtAantal.TabIndex = 1;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptions.Controls.Add(this.btnClearReknr);
            this.pnlOptions.Controls.Add(this.txtReknr);
            this.pnlOptions.Controls.Add(this.lblReknr);
            this.pnlOptions.Controls.Add(this.btnClearDatum);
            this.pnlOptions.Controls.Add(this.txtDatum);
            this.pnlOptions.Controls.Add(this.lblDatum);
            this.pnlOptions.Controls.Add(this.btnClearBtw);
            this.pnlOptions.Controls.Add(this.btnClearContact);
            this.pnlOptions.Controls.Add(this.btnClearLocatie);
            this.pnlOptions.Controls.Add(this.btnClearNaam);
            this.pnlOptions.Controls.Add(this.btnClearNr);
            this.pnlOptions.Controls.Add(this.label5);
            this.pnlOptions.Controls.Add(this.label4);
            this.pnlOptions.Controls.Add(this.label3);
            this.pnlOptions.Controls.Add(this.label2);
            this.pnlOptions.Controls.Add(this.label1);
            this.pnlOptions.Controls.Add(this.txtBtw);
            this.pnlOptions.Controls.Add(this.txtContact);
            this.pnlOptions.Controls.Add(this.txtLocatie);
            this.pnlOptions.Controls.Add(this.txtNaam);
            this.pnlOptions.Controls.Add(this.txtNr);
            this.pnlOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(533, 150);
            this.pnlOptions.TabIndex = 15;
            // 
            // btnClearReknr
            // 
            this.btnClearReknr.Location = new System.Drawing.Point(488, 100);
            this.btnClearReknr.Name = "btnClearReknr";
            this.btnClearReknr.Size = new System.Drawing.Size(26, 20);
            this.btnClearReknr.TabIndex = 37;
            this.btnClearReknr.Text = "button1";
            this.btnClearReknr.UseVisualStyleBackColor = true;
            this.btnClearReknr.Click += new System.EventHandler(this.btnClearReknr_Click);
            // 
            // txtReknr
            // 
            this.txtReknr.Location = new System.Drawing.Point(328, 101);
            this.txtReknr.Name = "txtReknr";
            this.txtReknr.Size = new System.Drawing.Size(147, 20);
            this.txtReknr.TabIndex = 36;
            // 
            // lblReknr
            // 
            this.lblReknr.AutoSize = true;
            this.lblReknr.Location = new System.Drawing.Point(255, 104);
            this.lblReknr.Name = "lblReknr";
            this.lblReknr.Size = new System.Drawing.Size(67, 13);
            this.lblReknr.TabIndex = 35;
            this.lblReknr.Text = "Rekening Nr";
            // 
            // btnClearDatum
            // 
            this.btnClearDatum.Location = new System.Drawing.Point(488, 48);
            this.btnClearDatum.Name = "btnClearDatum";
            this.btnClearDatum.Size = new System.Drawing.Size(26, 20);
            this.btnClearDatum.TabIndex = 34;
            this.btnClearDatum.Text = "button1";
            this.btnClearDatum.UseVisualStyleBackColor = true;
            this.btnClearDatum.Click += new System.EventHandler(this.btnClearDatum_Click);
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(328, 49);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(147, 20);
            this.txtDatum.TabIndex = 33;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(284, 52);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 32;
            this.lblDatum.Text = "Datum";
            // 
            // btnClearBtw
            // 
            this.btnClearBtw.Location = new System.Drawing.Point(223, 100);
            this.btnClearBtw.Name = "btnClearBtw";
            this.btnClearBtw.Size = new System.Drawing.Size(26, 20);
            this.btnClearBtw.TabIndex = 31;
            this.btnClearBtw.Text = "button1";
            this.btnClearBtw.UseVisualStyleBackColor = true;
            this.btnClearBtw.Click += new System.EventHandler(this.btnClearBtw_Click);
            // 
            // btnClearContact
            // 
            this.btnClearContact.Location = new System.Drawing.Point(488, 74);
            this.btnClearContact.Name = "btnClearContact";
            this.btnClearContact.Size = new System.Drawing.Size(26, 20);
            this.btnClearContact.TabIndex = 30;
            this.btnClearContact.Text = "button1";
            this.btnClearContact.UseVisualStyleBackColor = true;
            this.btnClearContact.Click += new System.EventHandler(this.btnClearContact_Click);
            // 
            // btnClearLocatie
            // 
            this.btnClearLocatie.Location = new System.Drawing.Point(223, 74);
            this.btnClearLocatie.Name = "btnClearLocatie";
            this.btnClearLocatie.Size = new System.Drawing.Size(26, 20);
            this.btnClearLocatie.TabIndex = 29;
            this.btnClearLocatie.Text = "button1";
            this.btnClearLocatie.UseVisualStyleBackColor = true;
            this.btnClearLocatie.Click += new System.EventHandler(this.btnClearLocatie_Click);
            // 
            // btnClearNaam
            // 
            this.btnClearNaam.Location = new System.Drawing.Point(223, 48);
            this.btnClearNaam.Name = "btnClearNaam";
            this.btnClearNaam.Size = new System.Drawing.Size(26, 20);
            this.btnClearNaam.TabIndex = 28;
            this.btnClearNaam.Text = "button1";
            this.btnClearNaam.UseVisualStyleBackColor = true;
            this.btnClearNaam.Click += new System.EventHandler(this.btnClearNaam_Click);
            // 
            // btnClearNr
            // 
            this.btnClearNr.Location = new System.Drawing.Point(223, 19);
            this.btnClearNr.Name = "btnClearNr";
            this.btnClearNr.Size = new System.Drawing.Size(26, 20);
            this.btnClearNr.TabIndex = 27;
            this.btnClearNr.Text = "button1";
            this.btnClearNr.UseVisualStyleBackColor = true;
            this.btnClearNr.Click += new System.EventHandler(this.btnClearNr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Btw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Locatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nr";
            // 
            // txtBtw
            // 
            this.txtBtw.Location = new System.Drawing.Point(63, 101);
            this.txtBtw.Name = "txtBtw";
            this.txtBtw.Size = new System.Drawing.Size(147, 20);
            this.txtBtw.TabIndex = 21;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(328, 75);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(147, 20);
            this.txtContact.TabIndex = 20;
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(63, 75);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(147, 20);
            this.txtLocatie.TabIndex = 19;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(63, 49);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(147, 20);
            this.txtNaam.TabIndex = 18;
            // 
            // txtNr
            // 
            this.txtNr.Location = new System.Drawing.Point(63, 20);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(54, 20);
            this.txtNr.TabIndex = 17;
            // 
            // FBeheerKlanten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 651);
            this.Controls.Add(this.fraDetails);
            this.Controls.Add(this.brKlanten);
            this.Controls.Add(this.imgBot);
            this.Controls.Add(this.imgTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FBeheerKlanten";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Beheer Klanten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brKlanten)).EndInit();
            this.fraDetails.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTop;
        private System.Windows.Forms.PictureBox imgBot;
        private System.Windows.Forms.DataGridView brKlanten;
        private System.Windows.Forms.Panel fraDetails;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnClearReknr;
        private System.Windows.Forms.TextBox txtReknr;
        private System.Windows.Forms.Label lblReknr;
        private System.Windows.Forms.Button btnClearDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnClearBtw;
        private System.Windows.Forms.Button btnClearContact;
        private System.Windows.Forms.Button btnClearLocatie;
        private System.Windows.Forms.Button btnClearNaam;
        private System.Windows.Forms.Button btnClearNr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBtw;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.RadioButton rbLimiet;
        private System.Windows.Forms.RadioButton rbAlle;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn klantenid;
        private System.Windows.Forms.DataGridViewTextBoxColumn naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn btwnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn reknr;
    }
}

