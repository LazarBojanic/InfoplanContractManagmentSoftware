using CSharp_SQL_App.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_SQL_App {
    public partial class UpdateForm : Form {

        private Ugovor oldUgovor;
        private Ugovor newUgovor;
        public UpdateForm() {
            InitializeComponent();
         
        }

        public void loadUgovor(int id) {
            oldUgovor = new Ugovor();
            newUgovor = new Ugovor();
            if (id != 0) {
                oldUgovor.loadFromDatabase(id);
            }
        }
        
        private void UpdateForm_Load(object sender, EventArgs e) {
            textBoxId.Text = oldUgovor.id.ToString();
            textBoxOpstina.Text = oldUgovor.opstina;
            textBoxNazivPlana.Text = oldUgovor.nazivPlana;
            textBoxUrbanista.Text = oldUgovor.urbanista;
            textBoxFaza.Text = oldUgovor.faza;
            textBoxNapomena.Text = oldUgovor.napomena;
            textBoxDatumUgovora.Text = oldUgovor.datumUgovora.ToString();
            textBoxRokPoUgovoru.Text = oldUgovor.rokPoUgovoru;
            textBoxObim.Text = oldUgovor.obim.ToString();
            textBoxKrajnjiRok.Text = oldUgovor.krajnjiRok.ToString();
            textBoxPrioritet.Text = oldUgovor.prioritet.ToString();
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e) {

        }

        private void buttonOtkazi_Click(object sender, EventArgs e) {

        }
    }
}
