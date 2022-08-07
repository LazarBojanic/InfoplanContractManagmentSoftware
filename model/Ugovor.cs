using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App.model {
    public class Ugovor {
        public int id { get; set; }
        public String opstina { get; set; }
        public String nazivPlana { get; set; }
        public String urbanista { get; set; }
        public String faza { get; set; }
        public String napomena { get; set; }
        public DateTime datumUgovora { get; set; }
        public String rokPoUgovoru { get; set; }
        public int obim { get; set; }
        public DateTime krajnjiRok { get; set; }
        public int prioritet { get; set; }
        public String uGuid { get; set; }
        public DateTime vremeUgovora { get; set; }

        public Ugovor(int id, string opstina, string nazivPlana, string urbanista, string faza,
            string napomena, DateTime datumUgovora, string rokPoUgovoru, int obim,
            DateTime krajnjiRok, int prioritet, String uGuid, DateTime vremeUgovora) {
            this.id = id;
            this.opstina = opstina;
            this.nazivPlana = nazivPlana;
            this.urbanista = urbanista;
            this.faza = faza;
            this.napomena = napomena;
            this.datumUgovora = datumUgovora;
            this.rokPoUgovoru = rokPoUgovoru;
            this.obim = obim;
            this.krajnjiRok = krajnjiRok;
            this.prioritet = prioritet;
            this.uGuid = uGuid;
            this.vremeUgovora = vremeUgovora;
        }
        public Ugovor() {
            this.id = 0;
            this.opstina = "";
            this.nazivPlana = "";
            this.urbanista = "";
            this.faza = "";
            this.napomena = "";
            this.datumUgovora = DateTime.Today;
            this.rokPoUgovoru = "";
            this.obim = 0;
            this.krajnjiRok = DateTime.Today;
            this.prioritet = 0;
            this.uGuid = Guid.NewGuid().ToString();
            this.vremeUgovora = DateTime.Now;
        }
        public bool loadFromDatabase(int parId) {
            OleDbConnection connection = GetConnection();
            connection.Open();
            string query = "SELECT * FROM ugovor WHERE id = @id";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@id", parId);
            OleDbDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows) {
                dataReader.Read();
                try {
                    id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        id = 0;
                    }
                }
                try {
                    opstina = dataReader.GetString(dataReader.GetOrdinal("opstina"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        opstina = "";
                    }
                }
                try {
                    nazivPlana = dataReader.GetString(dataReader.GetOrdinal("nazivPlana"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        nazivPlana = "";
                    }
                }
                try {
                    urbanista = dataReader.GetString(dataReader.GetOrdinal("urbanista"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        urbanista = "";
                    }
                }
                try {
                    faza = dataReader.GetString(dataReader.GetOrdinal("faza"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        faza = "";
                    }
                }
                try {
                    napomena = dataReader.GetString(dataReader.GetOrdinal("napomena"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        napomena = "";
                    }
                }
                try {
                    datumUgovora = dataReader.GetDateTime(dataReader.GetOrdinal("datumUgovora"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        datumUgovora = DateTime.Today;
                    }
                }
                try {
                    rokPoUgovoru = dataReader.GetString(dataReader.GetOrdinal("rokPoUgovoru"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        rokPoUgovoru = "";
                    }
                }
                try {
                    obim = dataReader.GetInt32(dataReader.GetOrdinal("obim"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        obim = 0;
                    }
                }
                try {
                    krajnjiRok = dataReader.GetDateTime(dataReader.GetOrdinal("krajnjiRok"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        krajnjiRok = DateTime.Today;
                    }
                }
                try {
                    prioritet = dataReader.GetInt32(dataReader.GetOrdinal("prioritet"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        prioritet = 0;
                    }
                }
                try {
                    uGuid = dataReader.GetString(dataReader.GetOrdinal("uGuid"));
                }
                catch (Exception ex) {
                    if (ex is NullReferenceException || ex is InvalidCastException) {
                        uGuid = "";
                    }
                }
                connection.Close();
                return true;
            }
            else {
                MessageBox.Show("Ne postoji id", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
        }
        public void saveToDatabase() {
            OleDbConnection connection = GetConnection();
            connection.Open();
            vremeUgovora = DateTime.Now;
            if (id == 0) {
                string query = "INSERT INTO ugovor (opstina, nazivPlana, urbanista, faza, napomena, datumUgovora," +
                    " rokPoUgovoru, obim, krajnjiRok, prioritet, uGuid) VALUES (@opstina, @nazivPlana, @urbanista, @faza, @napomena," +
                    " @datumUgovora, @rokPoUgovoru, @obim, @krajnjiRok, @prioritet, vremeUgovora = @vremeUgovora, @uGuid)";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@opstina", opstina);
                command.Parameters.AddWithValue("@nazivPlana", nazivPlana);
                command.Parameters.AddWithValue("@urbanista", urbanista);
                command.Parameters.AddWithValue("@faza", faza);
                command.Parameters.AddWithValue("@napomena", napomena);
                command.Parameters.AddWithValue("@datumUgovora", datumUgovora);
                command.Parameters.AddWithValue("@rokPoUgovoru", rokPoUgovoru);
                command.Parameters.AddWithValue("@obim", obim);
                command.Parameters.AddWithValue("@krajnjiRok", krajnjiRok);
                command.Parameters.AddWithValue("@prioritet", prioritet);
                command.Parameters.AddWithValue("@vremeUgovora", vremeUgovora);
                command.Parameters.AddWithValue("@uGuid", uGuid);
                int recordsAffected = command.ExecuteNonQuery();
            }
            else {
                string query = "UPDATE ugovor SET opstina = @opstina, nazivPlana = @nazivPlana, urbanista = @urbanista," +
                    " faza = @faza, napomena = @napomena, datumUgovora = @datumUgovora, rokPoUgovoru = @rokPoUgovoru, obim = @obim," +
                    " krajnjiRok = @krajnjiRok, prioritet = @prioritet, vremeUgovora = @vremeUgovora WHERE id = @id";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@opstina", opstina);
                command.Parameters.AddWithValue("@nazivPlana", nazivPlana);
                command.Parameters.AddWithValue("@urbanista", urbanista);
                command.Parameters.AddWithValue("@faza", faza);
                command.Parameters.AddWithValue("@napomena", napomena);
                command.Parameters.AddWithValue("@datumUgovora", datumUgovora);
                command.Parameters.AddWithValue("@rokPoUgovoru", rokPoUgovoru);
                command.Parameters.AddWithValue("@obim", obim);
                command.Parameters.AddWithValue("@krajnjiRok", krajnjiRok);
                command.Parameters.AddWithValue("@prioritet", prioritet);
                command.Parameters.AddWithValue("@vremeUgovora", vremeUgovora);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private static OleDbConnection GetConnection() {
            return new OleDbConnection(Properties.Settings.Default.ugovoriConnectionString);
        }



    }
}
