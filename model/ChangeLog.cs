using CSharp_SQL_App.util;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CSharp_SQL_App.model {
    public class ChangeLog {
        public int id { get;set;}
        public string imeTabele { get;set; }
        public string imePolja { get;set; }
        public string tipAkcije { get;set; }
        public string primarniKljuc { get;set; }
        public string staraVrednost { get;set; }
        public string novaVrednost { get;set; }

        public ChangeLog(int id, string imeTabele, string imePolja, string tipAkcije, string primarniKljuc, string staraVrednost, string novaVrednost) {
            this.id = id;
            this.imeTabele = imeTabele;
            this.imePolja = imePolja;
            this.tipAkcije = tipAkcije;
            this.primarniKljuc = primarniKljuc;
            this.staraVrednost = staraVrednost;
            this.novaVrednost = novaVrednost;
        }
        public static void addChangeLogField(String imeTabele, string imePolja, string tipAkcije,
            string primarniKljuc, string staraVrednost, string novaVrednost) {
            try {
                OleDbConnection connection = Util.GetConnection();
                connection.Open();
                DateTime vremeAkcije = DateTime.Now;
                string username = MainForm.user.username;
                string query = "INSERT INTO [changeLog] (imeTabele, imePolja, tipAkcije," +
                    " vremeAkcije, [username], primarniKljuc, staraVrednost, novaVrednost) VALUES" +
                    " (@imeTabele, @imePolja, @tipAkcije, @vremeAkcije, @username," +
                    " @primarniKljuc, @staraVrednost, @novaVrednost)";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@imeTabele", imeTabele);
                command.Parameters.AddWithValue("@imePolja", imePolja);
                command.Parameters.AddWithValue("@tipAkcije", tipAkcije);
                command.Parameters.Add("@vremeAkcije", OleDbType.DBTimeStamp).Value = Util.dateTimeWithoutMilliseconds(vremeAkcije);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@primarniKljuc", primarniKljuc);
                command.Parameters.AddWithValue("@staraVrednost", staraVrednost);
                command.Parameters.AddWithValue("@novaVrednost", novaVrednost);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public static void addChangeLogForUgovor(Ugovor oldUgovor, Ugovor newUgovor) {
            if (oldUgovor.id == 0) {
                if (!oldUgovor.opstina.Equals(newUgovor.opstina)) {
                    addChangeLogField("ugovor", "opstina", "kreairanje", oldUgovor.uGuid, oldUgovor.opstina, newUgovor.opstina);
                }
                if (!oldUgovor.nazivPlana.Equals(newUgovor.nazivPlana)) {
                    addChangeLogField("ugovor", "nazivPlana", "kreairanje", oldUgovor.uGuid, oldUgovor.nazivPlana, newUgovor.nazivPlana);
                }
                if (!oldUgovor.urbanista.Equals(newUgovor.urbanista)) {
                    addChangeLogField("ugovor", "urbanista", "kreairanje", oldUgovor.uGuid, oldUgovor.urbanista, newUgovor.urbanista);
                }
                if (!oldUgovor.tipUgovora.Equals(newUgovor.tipUgovora)) {
                    addChangeLogField("ugovor", "tipUgovora", "kreairanje", oldUgovor.uGuid, oldUgovor.tipUgovora, newUgovor.tipUgovora);
                }
                if (!oldUgovor.faza.Equals(newUgovor.faza)) {
                    addChangeLogField("ugovor", "faza", "kreairanje", oldUgovor.uGuid, oldUgovor.faza, newUgovor.faza);
                }
                if (!oldUgovor.napomena.Equals(newUgovor.napomena)) {
                    addChangeLogField("ugovor", "napomena", "kreairanje", oldUgovor.uGuid, oldUgovor.napomena, newUgovor.napomena);
                }
                if (!oldUgovor.datumUgovora.Equals(newUgovor.datumUgovora)) {
                    addChangeLogField("ugovor", "datumUgovora", "kreairanje", oldUgovor.uGuid, oldUgovor.datumUgovora.ToString(), newUgovor.datumUgovora.ToString());
                }
                if (!oldUgovor.rokPoUgovoru.Equals(newUgovor.rokPoUgovoru)) {
                    addChangeLogField("ugovor", "rokPoUgovoru", "kreairanje", oldUgovor.uGuid, oldUgovor.rokPoUgovoru, newUgovor.rokPoUgovoru);
                }
                if (!oldUgovor.krajnjiRok.Equals(newUgovor.krajnjiRok)) {
                    addChangeLogField("ugovor", "krajnjiRok", "kreairanje", oldUgovor.uGuid, oldUgovor.krajnjiRok.ToString(), newUgovor.krajnjiRok.ToString());
                }
                if (!oldUgovor.obim.Equals(newUgovor.obim)) {
                    addChangeLogField("ugovor", "obim", "kreairanje", oldUgovor.uGuid, oldUgovor.obim.ToString(), newUgovor.obim.ToString());
                }
                if (!oldUgovor.prioritet.Equals(newUgovor.prioritet)) {
                    addChangeLogField("ugovor", "prioritet", "kreairanje", oldUgovor.uGuid, oldUgovor.prioritet.ToString(), newUgovor.prioritet.ToString());
                }
                if (!oldUgovor.cena.Equals(newUgovor.cena)) {
                    addChangeLogField("ugovor", "cena", "kreairanje", oldUgovor.uGuid, oldUgovor.cena.ToString(), newUgovor.cena.ToString());
                }
                if (!oldUgovor.usvojen.Equals(newUgovor.usvojen)) {
                    addChangeLogField("ugovor", "usvojen", "kreairanje", oldUgovor.uGuid, oldUgovor.usvojen.ToString(), newUgovor.usvojen.ToString());
                }
                if (!oldUgovor.datumUsvajanja.Equals(newUgovor.datumUsvajanja)) {
                    addChangeLogField("ugovor", "datumUsvajanja", "kreairanje", oldUgovor.uGuid, oldUgovor.datumUsvajanja.ToString(), newUgovor.datumUsvajanja.ToString());
                }
                if (!oldUgovor.brojSluzbenogVlasnika.Equals(newUgovor.brojSluzbenogVlasnika)) {
                    addChangeLogField("ugovor", "brojSluzbenogVlasnika", "kreairanje", oldUgovor.uGuid, oldUgovor.brojSluzbenogVlasnika.ToString(), newUgovor.brojSluzbenogVlasnika.ToString());
                }
                if (!oldUgovor.vremeRada.Equals(newUgovor.vremeRada)) {
                    addChangeLogField("ugovor", "vremeRada", "kreairanje", oldUgovor.uGuid, oldUgovor.vremeRada.ToString(), newUgovor.vremeRada.ToString());
                }
            }
            else if (newUgovor.id == 0) {
                if (!oldUgovor.opstina.Equals(newUgovor.opstina)) {
                    addChangeLogField("ugovor", "opstina", "brisanje", oldUgovor.uGuid, oldUgovor.opstina, newUgovor.opstina);
                }
                if (!oldUgovor.nazivPlana.Equals(newUgovor.nazivPlana)) {
                    addChangeLogField("ugovor", "nazivPlana", "brisanje", oldUgovor.uGuid, oldUgovor.nazivPlana, newUgovor.nazivPlana);
                }
                if (!oldUgovor.urbanista.Equals(newUgovor.urbanista)) {
                    addChangeLogField("ugovor", "urbanista", "brisanje", oldUgovor.uGuid, oldUgovor.urbanista, newUgovor.urbanista);
                }
                if (!oldUgovor.tipUgovora.Equals(newUgovor.tipUgovora)) {
                    addChangeLogField("ugovor", "tipUgovora", "brisanje", oldUgovor.uGuid, oldUgovor.tipUgovora, newUgovor.tipUgovora);
                }
                if (!oldUgovor.faza.Equals(newUgovor.faza)) {
                    addChangeLogField("ugovor", "faza", "brisanje", oldUgovor.uGuid, oldUgovor.faza, newUgovor.faza);
                }
                if (!oldUgovor.napomena.Equals(newUgovor.napomena)) {
                    addChangeLogField("ugovor", "napomena", "brisanje", oldUgovor.uGuid, oldUgovor.napomena, newUgovor.napomena);
                }
                if (!oldUgovor.datumUgovora.Equals(newUgovor.datumUgovora)) {
                    addChangeLogField("ugovor", "datumUgovora", "brisanje", oldUgovor.uGuid, oldUgovor.datumUgovora.ToString(), newUgovor.datumUgovora.ToString());
                }
                if (!oldUgovor.rokPoUgovoru.Equals(newUgovor.rokPoUgovoru)) {
                    addChangeLogField("ugovor", "rokPoUgovoru", "brisanje", oldUgovor.uGuid, oldUgovor.rokPoUgovoru, newUgovor.rokPoUgovoru);
                }
                if (!oldUgovor.krajnjiRok.Equals(newUgovor.krajnjiRok)) {
                    addChangeLogField("ugovor", "krajnjiRok", "brisanje", oldUgovor.uGuid, oldUgovor.krajnjiRok.ToString(), newUgovor.krajnjiRok.ToString());
                }
                if (!oldUgovor.obim.Equals(newUgovor.obim)) {
                    addChangeLogField("ugovor", "obim", "brisanje", oldUgovor.uGuid, oldUgovor.obim.ToString(), newUgovor.obim.ToString());
                }
                if (!oldUgovor.prioritet.Equals(newUgovor.prioritet)) {
                    addChangeLogField("ugovor", "prioritet", "brisanje", oldUgovor.uGuid, oldUgovor.prioritet.ToString(), newUgovor.prioritet.ToString());
                }
                if (!oldUgovor.cena.Equals(newUgovor.cena)) {
                    addChangeLogField("ugovor", "cena", "brisanje", oldUgovor.uGuid, oldUgovor.cena.ToString(), newUgovor.cena.ToString());
                }
                if (!oldUgovor.usvojen.Equals(newUgovor.usvojen)) {
                    addChangeLogField("ugovor", "usvojen", "brisanje", oldUgovor.uGuid, oldUgovor.usvojen.ToString(), newUgovor.usvojen.ToString());
                }
                if (!oldUgovor.datumUsvajanja.Equals(newUgovor.datumUsvajanja)) {
                    addChangeLogField("ugovor", "datumUsvajanja", "brisanje", oldUgovor.uGuid, oldUgovor.datumUsvajanja.ToString(), newUgovor.datumUsvajanja.ToString());
                }
                if (!oldUgovor.brojSluzbenogVlasnika.Equals(newUgovor.brojSluzbenogVlasnika)) {
                    addChangeLogField("ugovor", "brojSluzbenogVlasnika", "brisanje", oldUgovor.uGuid, oldUgovor.brojSluzbenogVlasnika.ToString(), newUgovor.brojSluzbenogVlasnika.ToString());
                }
                if (!oldUgovor.vremeRada.Equals(newUgovor.vremeRada)) {
                    addChangeLogField("ugovor", "vremeRada", "brisanje", oldUgovor.uGuid, oldUgovor.vremeRada.ToString(), newUgovor.vremeRada.ToString());
                }
            }
            else {
                if (!oldUgovor.opstina.Equals(newUgovor.opstina)) {
                    addChangeLogField("ugovor", "opstina", "promena", oldUgovor.uGuid, oldUgovor.opstina, newUgovor.opstina);
                }
                if (!oldUgovor.nazivPlana.Equals(newUgovor.nazivPlana)) {
                    addChangeLogField("ugovor", "nazivPlana", "promena", oldUgovor.uGuid, oldUgovor.nazivPlana, newUgovor.nazivPlana);
                }
                if (!oldUgovor.urbanista.Equals(newUgovor.urbanista)) {
                    addChangeLogField("ugovor", "urbanista", "promena", oldUgovor.uGuid, oldUgovor.urbanista, newUgovor.urbanista);
                }
                if (!oldUgovor.tipUgovora.Equals(newUgovor.tipUgovora)) {
                    addChangeLogField("ugovor", "tipUgovora", "promena", oldUgovor.uGuid, oldUgovor.tipUgovora, newUgovor.tipUgovora);
                }
                if (!oldUgovor.faza.Equals(newUgovor.faza)) {
                    addChangeLogField("ugovor", "faza", "promena", oldUgovor.uGuid, oldUgovor.faza, newUgovor.faza);
                }
                if (!oldUgovor.napomena.Equals(newUgovor.napomena)) {
                    addChangeLogField("ugovor", "napomena", "promena", oldUgovor.uGuid, oldUgovor.napomena, newUgovor.napomena);
                }
                if (!oldUgovor.datumUgovora.Equals(newUgovor.datumUgovora)) {
                    addChangeLogField("ugovor", "datumUgovora", "promena", oldUgovor.uGuid, oldUgovor.datumUgovora.ToString(), newUgovor.datumUgovora.ToString());
                }
                if (!oldUgovor.rokPoUgovoru.Equals(newUgovor.rokPoUgovoru)) {
                    addChangeLogField("ugovor", "rokPoUgovoru", "promena", oldUgovor.uGuid, oldUgovor.rokPoUgovoru, newUgovor.rokPoUgovoru);
                }
                if (!oldUgovor.krajnjiRok.Equals(newUgovor.krajnjiRok)) {
                    addChangeLogField("ugovor", "krajnjiRok", "promena", oldUgovor.uGuid, oldUgovor.krajnjiRok.ToString(), newUgovor.krajnjiRok.ToString());
                }
                if (!oldUgovor.obim.Equals(newUgovor.obim)) {
                    addChangeLogField("ugovor", "obim", "promena", oldUgovor.uGuid, oldUgovor.obim.ToString(), newUgovor.obim.ToString());
                }
                if (!oldUgovor.prioritet.Equals(newUgovor.prioritet)) {
                    addChangeLogField("ugovor", "prioritet", "promena", oldUgovor.uGuid, oldUgovor.prioritet.ToString(), newUgovor.prioritet.ToString());
                }
                if (!oldUgovor.cena.Equals(newUgovor.cena)) {
                    addChangeLogField("ugovor", "cena", "promena", oldUgovor.uGuid, oldUgovor.cena.ToString(), newUgovor.cena.ToString());
                }
                if (!oldUgovor.usvojen.Equals(newUgovor.usvojen)) {
                    addChangeLogField("ugovor", "usvojen", "promena", oldUgovor.uGuid, oldUgovor.usvojen.ToString(), newUgovor.usvojen.ToString());
                }
                if (!oldUgovor.datumUsvajanja.Equals(newUgovor.datumUsvajanja)) {
                    addChangeLogField("ugovor", "datumUsvajanja", "promena", oldUgovor.uGuid, oldUgovor.datumUsvajanja.ToString(), newUgovor.datumUsvajanja.ToString());
                }
                if (!oldUgovor.brojSluzbenogVlasnika.Equals(newUgovor.brojSluzbenogVlasnika)) {
                    addChangeLogField("ugovor", "brojSluzbenogVlasnika", "promena", oldUgovor.uGuid, oldUgovor.brojSluzbenogVlasnika.ToString(), newUgovor.brojSluzbenogVlasnika.ToString());
                }
                if (!oldUgovor.vremeRada.Equals(newUgovor.vremeRada)) {
                    addChangeLogField("ugovor", "vremeRada", "promena", oldUgovor.uGuid, oldUgovor.vremeRada.ToString(), newUgovor.vremeRada.ToString());
                }
            }
        }
    }
}