using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4D_klanten
{
    public partial class Form2 : Form
    {
        bool _FieldLock = false;
        DataRow _Row;

        public event EventHandler<UpdatedEventArgs> updateEvent;

        //public delegate void refreshMain(DataRow row);

        Klanten kla = new Klanten();

        public class UpdatedEventArgs : EventArgs
        {
            public DataRow SomeVal { get; set; } // create custom event arg for your need
        }

        protected virtual void OnFirstUpdateEvent(UpdatedEventArgs e)
        {
            if (updateEvent != null)
                updateEvent(this, e);
        }
                
        public Form2()
        {
            InitializeComponent();
            Initialize();
        }

        public void openDetail(DataRow row, bool fieldlock)
        {
            _FieldLock = fieldlock;
            _Row = row;

            lockFields(_FieldLock);
            string test = _Row[0].ToString();
            kla.transform(Convert.ToInt32(test));

            txtNaam.Text = _Row[1].ToString();
            txtLand.Text = _Row[2].ToString();
            txtGemeente.Text = _Row[3].ToString();
            txtPostcode.Text = _Row[12].ToString();
            txtStraat.Text = _Row[4].ToString();
            txtNr.Text = _Row[5].ToString();
            txtBus.Text = _Row[6].ToString();
            txtTel1.Text = _Row[10].ToString();
            txtTel2.Text = _Row[11].ToString();
            txtContact.Text = _Row[9].ToString();
            txtBtw.Text = _Row[7].ToString();
            txtRekeningnr.Text = _Row[13].ToString();
            //imgLogo.Image = kla.Logo();
        }

        private void Initialize()
        {
            string path;
            path = "C:\\4D_Construct\\images\\";
            //MessageBox.Show(path);
            imgTop.Image = Image.FromFile(path + "toolbar.jpg");
            imgBot.Image = Image.FromFile(path + "toolbar.jpg");
        }

        private void lockFields(bool value)
        {
            txtNaam.ReadOnly = value;
            txtLand.ReadOnly = value;
            txtBtw.ReadOnly = value;
            txtContact.ReadOnly = value;
            txtBus.ReadOnly = value;
            txtGemeente.ReadOnly = value;
            txtPostcode.ReadOnly = value;
            txtStraat.ReadOnly = value;
            txtNr.ReadOnly = value;
            txtTel1.ReadOnly = value;
            txtTel2.ReadOnly = value;
            txtRekeningnr.ReadOnly = value;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_FieldLock)
            {
                lockFields(false);
                _FieldLock = false;
            }
            else
            {
                lockFields(true);
                _FieldLock = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_FieldLock == false)
            {
                /*----naar object schrijven----*/
                kla.Naam = txtNaam.Text;
                kla.Land = txtLand.Text;
                kla.Gemeente = txtGemeente.Text;
                kla.Postcode = txtPostcode.Text;
                kla.Straat = txtStraat.Text ;
                kla.Nr = txtNr.Text;
                kla.Bus = txtBus.Text;
                kla.Tel1 = txtTel1.Text;
                kla.Tel2 = txtTel2.Text;
                kla.Contact = txtContact.Text;
                kla.Btwnr = txtBtw.Text;
                kla.Reknr = txtRekeningnr.Text;
                //imgLogo.Image = kla.Logo();
                /*------------------------------*/
                //imgLogo.Image = kla.Logo();
                _Row[1] = txtNaam.Text;
                _Row[2] = txtLand.Text;
                _Row[3] = txtGemeente.Text;
                _Row[12] = txtPostcode.Text;
                _Row[4] = txtStraat.Text;
                _Row[5] = txtNr.Text;
                _Row[6] = txtBus.Text;
                _Row[10] = txtTel1.Text;
                _Row[11] = txtTel2.Text;
                _Row[9] = txtContact.Text;
                _Row[7] = txtBtw.Text;
                _Row[13] = txtRekeningnr.Text;

                if (kla.Save())
                {
                    UpdatedEventArgs eventData = new UpdatedEventArgs();
                    eventData.SomeVal = _Row; // set update event arguments, according to your need

                    OnFirstUpdateEvent(eventData);

                }
            }
        }
    }
}
