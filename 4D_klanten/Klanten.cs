using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace _4D_klanten
{
    public class Klanten
    {
        MySQL mySQL = new MySQL(); //TODO door nieuw te instantieren verlies ik connectie details.

        // properties v/h object gelinkt aan de tabel
        public int KlantenId { set; get; }
        public string Naam { get; set; }
        public string Land { get; set; }
        public string Gemeente { get; set; }
        public string Straat { get; set; }
        public string Nr { get; set; }
        public string Bus { get; set; }
        public string Btwnr { get; set; }
        public object Logo { get; set; }
        public string Contact { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Postcode { get; set; }
        public string Reknr { get; set; }

        private string cError { set; get; }

        //Constructor
        public Klanten(int Id)
        {
            clearProps();
            transform(Id);
        }

        public Klanten()
        {
            clearProps();
            KlantenId = 0;
            LoadRec();
        }

        public bool Save()
        {
            bool send;
            send = SaveRec();
            return send;
        }

        private bool SaveRec()
        {
            if (Validate())
            {
                //INSERT INTO phonebook(phone, firstname, lastname, address) VALUES('+1 123 456 7890', 'John', 'Doe', 'North America')
                //UPDATE Persons SET Address='Nissestien 67', City='Sandnes' WHERE LastName='Tjessem' AND FirstName='Jakob'
                if (KlantenId != 0) // edit
                {
                    //TODO use querybuilder
                    mySQL.Insert("UPDATE klanten SET naam='" + Naam + "', land='" + Land + "', gemeente='" + Gemeente + "', straat='" + Straat + "', nr='" + Nr + "', bus='" + Bus + "', btwnr='" + Btwnr + "', email='" + Contact + "', tel1='" + Tel1 + "', tel2='" + Tel2 + "', postcode='" + Postcode + "', reknr='" + Reknr + "' WHERE klantenid='" + KlantenId + "'");
                    return true; //todo
                }
                else // new
                {
                    return false;
                }
            }
            else { return false; }
        }

        private bool LoadRec()
        {
            DataTable tt = new DataTable();
            string cmd = "SELECT * FROM klanten WHERE klantenid = " + KlantenId.ToString();
            tt = mySQL.Select("klanten", cmd, false);
            if (tt.Rows.Count != 0)
            {
                Naam = tt.Rows[0][1].ToString();
                Land = tt.Rows[0][2].ToString();
                Gemeente = tt.Rows[0][3].ToString();
                Straat = tt.Rows[0][4].ToString();
                Nr = tt.Rows[0][5].ToString();
                Bus = tt.Rows[0][6].ToString();
                Btwnr = tt.Rows[0][7].ToString();
                Logo = tt.Rows[0][8];
                Contact = tt.Rows[0][9].ToString();
                Tel1 = tt.Rows[0][10].ToString();
                Tel2 = tt.Rows[0][11].ToString();
                Postcode = tt.Rows[0][12].ToString();
                Reknr = tt.Rows[0][13].ToString();
            }
            return true; //TODO
        }

        private bool Validate()
        {
            if (Naam != null)
            {
                if (Land != null)
                {
                    if (Gemeente != null)
                    {
                        if (Straat != null)
                        {
                            if (Nr != null)
                            {
                                if (Bus != null)
                                {
                                    if (Btwnr != null)
                                    {
                                        if (Contact != null)
                                        {
                                            if (Tel1 != null)
                                            {
                                                if (Tel2 != null)
                                                {
                                                    if (Postcode != null)
                                                    {
                                                        if (Reknr != null)
                                                        {
                                                            return true;
                                                        }
                                                        return false;
                                                    }
                                                    return false;
                                                }
                                                return false;
                                            }
                                            return false;
                                        }
                                        return false;
                                    }
                                    return false;
                                }
                                return false;
                            }
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        private void clearProps()
        {
            KlantenId = 0;
            Naam = string.Empty;
            Land = string.Empty;
            Gemeente = string.Empty;
            Straat = string.Empty;
            Nr = string.Empty;
            Bus = string.Empty;
            Logo = string.Empty;
            Contact = string.Empty;
            Tel1 = string.Empty;
            Tel2 = string.Empty;
            Postcode = string.Empty;
            Reknr = string.Empty;
        }

        public void transform(int Id)
        {
            KlantenId = Id;
            LoadRec();
        }
    }
}
