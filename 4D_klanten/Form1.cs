using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using MySql.Data.MySqlClient;

namespace _4D_klanten
{
    public partial class FBeheerKlanten : Form
    {
        MySQL mySQL = new MySQL();
        DataTable tt_klanten = new DataTable(); //temp table klanten
        DataRow _row;
        
        string cError = "";

        public delegate void openDetail(DataRow row, bool edit);

        public FBeheerKlanten()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialize();

            if(mySQL.Connect() != true)
            {
                MessageBox.Show(mySQL.Error);
            }

            fill_tt_klanten();
        }

        public void fill_tt_klanten()
        {
            brKlanten.Rows.Clear();
            tt_klanten = mySQL.Select("klanten", "select * from klanten", false);
            int i = 0;
            foreach (DataRow row in tt_klanten.Rows)
            {
                brKlanten.Rows.Add();
                brKlanten.Rows[i].Cells[0].Value = row[0].ToString();
                brKlanten.Rows[i].Cells[1].Value = row[1].ToString();
                brKlanten.Rows[i].Cells[2].Value = row[9].ToString();
                brKlanten.Rows[i].Cells[3].Value = row[7].ToString();
                brKlanten.Rows[i].Cells[4].Value = row[13].ToString();
                i++;
            }
        }       

        private void initialize()
        {
            string path;
            path = "C:\\4D_Construct\\images\\";
            //MessageBox.Show(path);
            imgTop.Image = Image.FromFile(path + "toolbar.jpg");
            imgBot.Image = Image.FromFile(path + "toolbar.jpg");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySQL.mySqlClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = makeQuery();
            brKlanten.Rows.Clear();
            int i = 0;
            foreach (DataRow row in tt_klanten.Select(query))
            {
                brKlanten.Rows.Add();
                brKlanten.Rows[i].Cells[0].Value = row[0].ToString();
                brKlanten.Rows[i].Cells[1].Value = row[1].ToString();
                brKlanten.Rows[i].Cells[2].Value = row[9].ToString();
                brKlanten.Rows[i].Cells[3].Value = row[7].ToString();
                brKlanten.Rows[i].Cells[4].Value = row[13].ToString();
                i++;
            }
        }

        private string makeQuery()
        {
            string query = "";
            if (txtNr.Text != string.Empty)
            {
                if (query != string.Empty) { query = query + " and "; }
                query = query + "klantenid = " + Convert.ToInt32(txtNr.Text);
            }
            if (txtNaam.Text != string.Empty)
            {
                if (query != string.Empty) { query = query + " and "; }
                query = query +  "naam = '" + txtNaam.Text + "'";
            }
            if (txtLocatie.Text != string.Empty)
            {
                if (query != string.Empty) { query = query + " and "; }
                query = query + "land = '" + txtLocatie.Text + "'";
            } 
            if (txtBtw.Text != string.Empty)
            {
                if (query != string.Empty) { query = query + " and "; }
                query = query + "btwnr = '" + Convert.ToInt32(txtBtw.Text);
            }
            if (txtContact.Text != string.Empty)
            {
                if (query != string.Empty) { query = query + " and "; }
                query = query + "email = '" + txtContact.Text + "'";
            }
            if (txtReknr.Text != string.Empty)
            {
                if (query != string.Empty) { query = query + " and "; }
                query = query + "reknr = '" + Convert.ToInt32(txtReknr.Text);
            }
            //if (txtNaam.Text != string.Empty)
            //{
            //    query = query + " and naam = '" + txtNaam.Text + "'";
            //}
            return query;
        }

        private void cleartxt(TextBox txt)
        {
            txt.Text = string.Empty;
        }

        private void btnClearNr_Click(object sender, EventArgs e)
        {
            cleartxt(txtNr);
        }

        private void btnClearNaam_Click(object sender, EventArgs e)
        {
            cleartxt(txtNaam);
        }

        private void btnClearLocatie_Click(object sender, EventArgs e)
        {
            cleartxt(txtLocatie);
        }

        private void btnClearBtw_Click(object sender, EventArgs e)
        {
            cleartxt(txtBtw);
        }

        private void btnClearDatum_Click(object sender, EventArgs e)
        {
            cleartxt(txtDatum);
        }

        private void btnClearContact_Click(object sender, EventArgs e)
        {
            cleartxt(txtContact);
        }

        private void btnClearReknr_Click(object sender, EventArgs e)
        {
            cleartxt(txtReknr);
        }

        private void brKlanten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.updateEvent += new EventHandler<Form2.UpdatedEventArgs>(form2_updateEvent);
            openDetail del = new openDetail(frm2.openDetail);
            object[] klaID = tt_klanten.Rows[e.RowIndex].ItemArray; //get klantID of selected row
            DataRow[] rowAray = tt_klanten.Select("klantenid = " + Convert.ToInt32(klaID[0])); // get full rowdata of selected row

            foreach (DataRow r in rowAray)
            {
                _row = r; // put rowdata in single datarow
            }

            del(_row, true);
            frm2.Show();
        }

        void form2_updateEvent(object sender, Form2.UpdatedEventArgs e)
        {
            if (e != null && e.SomeVal != null)
            {
                // Do the update on Form 1 
                // depend on your event arguments update the grid 
                brKlanten.Rows.Clear();
                int i = 0;
                foreach (DataRow row in tt_klanten.Rows)
                {
                    brKlanten.Rows.Add();
                    brKlanten.Rows[i].Cells[0].Value = row[0].ToString();
                    brKlanten.Rows[i].Cells[1].Value = row[1].ToString();
                    brKlanten.Rows[i].Cells[2].Value = row[9].ToString();
                    brKlanten.Rows[i].Cells[3].Value = row[7].ToString();
                    brKlanten.Rows[i].Cells[4].Value = row[13].ToString();
                    i++;
                }
            }

        }

    }
}
