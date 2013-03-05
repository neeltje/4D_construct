using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace _4D_klanten
{
    class MySQL
    {
        public MySqlConnection connection = new MySqlConnection();
        public MySqlDataAdapter data = new MySqlDataAdapter();
        public MySqlCommand cmd = new MySqlCommand();
        public DataSet dataset = new DataSet();
        public DataTable tt = new DataTable();

        public string host = "127.0.0.1";
        public string db = "4DConstruct";
        public string uid = "jens.malfait";
        public string password = "239803";

        string cError = "";

        public bool Connect()
        {
            bool connected = false;

            if (connection == null)
            {
                //nieuwe connectie opzetten
                connection = new MySqlConnection();
                connected = connectP();
                
            }
            else
            {
                //oude connecties verwijderen
                connection.Close();
                connection.Dispose();
                //nieuwe connectie opzetten
                connection = new MySqlConnection();
                connected = connectP();
            }
            mySqlClose();
            return connected;
        }
        
        public DataTable Select(string table, string command, bool slot)
        {
            /*aanmaken van nieuwe placeholders*/
            if (tt == null) { dataset = new DataSet(); }
            if (cmd == null) { cmd = new MySqlCommand(); }
            if (data == null) { data = new MySqlDataAdapter(); }
            MySqlTransaction tr = null;

            /*connectie opzetten*/
            connectP();

            /*transactie starten*/
            tr = connection.BeginTransaction();

            /*data ophalen in beveiligde modus of niet.*/
            if (slot)
            {
                /*exclusive mode*/
                try
                {
                    cmd.Connection = connection;
                    cmd.Transaction = tr;
                    cmd.CommandText = command + " FOR UPDATE";
                    cmd.ExecuteNonQuery();

                    data.SelectCommand = cmd;
                    data.Fill(dataset, table);
                    tt = new DataTable();
                    tt = dataset.Tables[table];

                    tr.Commit();
                }
                catch (Exception ex)
                {
                    try
                    {
                        tr.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        cError = ex2.ToString();
                    }
                    cError = ex.ToString();
                }
                finally
                {
                    mySqlClose();
                }
            }
            else
            {
                /*no-lock mode*/
                try
                {
                    cmd.Connection = connection;
                    cmd.CommandText = command;
                    cmd.ExecuteNonQuery();          // query uitvoeren
                    data.SelectCommand = cmd;       // command in dataadapter steken
                    data.Fill(dataset, table);      // in dataadapter naar dataset
                    tt = new DataTable();
                    tt = dataset.Tables[table];     // dataset naar datatable

                    tr.Commit();                    // commiten van de query, zal de lock releasen.
                }
                catch (Exception ex)
                {
                    try
                    {
                        tr.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        cError = ex2.ToString();
                    }
                    cError = ex.ToString();
                }
                finally
                {
                    mySqlClose();
                }
            }
            return tt;
        }

        public bool Insert(string command)
        {
            /*aanmaken van nieuwe placeholders*/
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction tr = null;
            bool output = false;

            /*connecten naar db*/
            connectP();

            /*transactie starten*/
            tr = connection.BeginTransaction();

            try
            {
                cmd.Connection = connection;
                cmd.Transaction = tr;
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();

                tr.Commit();
                output = true;
            }
            catch (Exception ex)
            {
                try
                {
                    tr.Rollback();
                }
                catch (Exception ex2)
                {
                    cError = ex2.ToString();
                }
                cError = ex.ToString();
                output = false;
            }
            finally
            {
                mySqlClose();
            }
            return output;
        }

        public string Error
        {
            get
            {
                return cError;
            }
        }

        public void mySqlClose()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private bool connectP()
        {
            bool connected = false;

            cError = "";
            connection.ConnectionString = "server=" + host + ";" + "database=" + db + ";" + "uid=" + uid + ";" + "password=" + password + ";";
            try
            {
                connection.Open();
                connected = true;
            }
            catch (Exception e)
            {
                cError = "Error while connecting to SQL server.\n"  + e.ToString();
                connected = false;
            }
            return connected;
        }
 
    }
}
