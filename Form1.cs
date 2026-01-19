using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RO_ManualSoft
{
    public partial class Form1 : Form
    {
        List<Eszkoz> eszkozok = new List<Eszkoz>();
        Eszkoz aktualis;

        
        TextBox tbNev;
        TextBox tbKep;
        TextBox tbManual;
        TextBox tbSzamla;
        ComboBox cbNyelv;
        Button btnBrowseKep;
        Button btnBrowseManual;
        Button btnBrowseSzamla;
        Button btnAddOk;
        Button btnAddCancel;
        Panel panelHozzaad;

        public Form1()
        {
            InitializeComponent();
            AlapAdatBetoltes();
            InitHozzaadPanel();
        }

        void AlapAdatBetoltes()
        {
            Eszkoz e = new Eszkoz()
            {
                Nev = "Osmo Pocket 3",
                Tipus = "Kamera",
                ManualPdf = "OsmoPocket3_manual.pdf",
                ManualNyelv = "Magyar",
                SzamlaPdf = "OsmoPocket3_szamla.pdf",
                Kep = "OsmoPocket3.jpg"
            };
            Eszkoz f = new Eszkoz()
            {
                Nev = "Logitech G502 Hero",
                Tipus = "Egér",
                ManualPdf = "G502Hero_manual.pdf",
                ManualNyelv = "Angol",
                SzamlaPdf = "G502Hero_szamla.pdf",
                Kep = "G502Hero.png"
            };
            Eszkoz g = new Eszkoz()
            {
                Nev = "Dyson V15",
                Tipus = "Porszívó",
                ManualPdf = "Dysonv15_manual.pdf",
                ManualNyelv = "Magyar",
                SzamlaPdf = "Dysonv15_szamla.pdf",
                Kep = "Dysonv15.jpeg"
            };
            Eszkoz h = new Eszkoz()
            {
                Nev = "Mas***bator Pro",
                Tipus = "",
                ManualPdf = "MasturbatorPro_manual.pdf",
                ManualNyelv = "Magyar",
                SzamlaPdf = "MasturbatorPro_szamla.pdf",
                Kep = "MasturbatorPro.jpg"
            };
            eszkozok.Add(h);
            listBoxEszkozok.Items.Add(h);
            eszkozok.Add(g);
            listBoxEszkozok.Items.Add(g);
            eszkozok.Add(f);
            listBoxEszkozok.Items.Add(f);
            eszkozok.Add(e);
            listBoxEszkozok.Items.Add(e);
        }

        private void listBoxEszkozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEszkozok.SelectedIndex == -1) return;

            aktualis = (Eszkoz)listBoxEszkozok.SelectedItem;
            pictureBox1.Image = File.Exists(aktualis.Kep) ? Image.FromFile(aktualis.Kep) : null;
            labelNyelv.Text = "Kézikönyv nyelve: " + aktualis.ManualNyelv;
            axAcroPDF1.Visible = false;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (aktualis != null) PdfMegnyit(aktualis.ManualPdf);
        }

        private void btnSzamla_Click(object sender, EventArgs e)
        {
            if (aktualis != null) PdfMegnyit(aktualis.SzamlaPdf);
        }

        void PdfMegnyit(string fajl)
        {
            if (File.Exists(fajl))
            {
                axAcroPDF1.LoadFile(fajl);
                axAcroPDF1.Visible = true;
            }
            else
            {
                MessageBox.Show("A PDF nem található!");
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (listBoxEszkozok.SelectedIndex == -1) return;
            Eszkoz torlendo = (Eszkoz)listBoxEszkozok.SelectedItem;
            eszkozok.Remove(torlendo);
            listBoxEszkozok.Items.Remove(torlendo);

            pictureBox1.Image = null;
            labelNyelv.Text = "";
            axAcroPDF1.Visible = false;
            aktualis = null;
        }

        private void InitHozzaadPanel()
        {
            panelHozzaad = new Panel();
            panelHozzaad.Size = new Size(400, 250);
            panelHozzaad.Location = new Point(20, 380);
            panelHozzaad.BorderStyle = BorderStyle.FixedSingle;

            Label lblNev = new Label() { Text = "Név:", Location = new Point(10, 10), AutoSize = true };
            tbNev = new TextBox() { Location = new Point(100, 10), Width = 250 };

            Label lblKep = new Label() { Text = "Kép:", Location = new Point(10, 40), AutoSize = true };
            tbKep = new TextBox() { Location = new Point(100, 40), Width = 200 };
            btnBrowseKep = new Button() { Text = "Tallóz", Location = new Point(310, 38), Size = new Size(70, 25) };
            btnBrowseKep.Click += BtnBrowseKep_Click;

            Label lblManual = new Label() { Text = "Manual PDF:", Location = new Point(10, 70), AutoSize = true };
            tbManual = new TextBox() { Location = new Point(100, 70), Width = 200 };
            btnBrowseManual = new Button() { Text = "Tallóz", Location = new Point(310, 68), Size = new Size(70, 25) };
            btnBrowseManual.Click += BtnBrowseManual_Click;

            Label lblSzamla = new Label() { Text = "Számla PDF:", Location = new Point(10, 100), AutoSize = true };
            tbSzamla = new TextBox() { Location = new Point(100, 100), Width = 200 };
            btnBrowseSzamla = new Button() { Text = "Tallóz", Location = new Point(310, 98), Size = new Size(70, 25) };
            btnBrowseSzamla.Click += BtnBrowseSzamla_Click;

            Label lblNyelv = new Label() { Text = "Nyelv:", Location = new Point(10, 130), AutoSize = true };
            cbNyelv = new ComboBox() { Location = new Point(100, 130), Width = 150 };
            cbNyelv.Items.AddRange(new string[] { "Magyar", "Angol" });
            cbNyelv.SelectedIndex = 0;

            btnAddOk = new Button() { Text = "Hozzáadás", Location = new Point(100, 170), Size = new Size(100, 30) };
            btnAddOk.Click += BtnAddOk_Click;

            btnAddCancel = new Button() { Text = "Mégse", Location = new Point(220, 170), Size = new Size(100, 30) };
            btnAddCancel.Click += BtnAddCancel_Click;

            panelHozzaad.Controls.AddRange(new Control[] {
                lblNev, tbNev,
                lblKep, tbKep, btnBrowseKep,
                lblManual, tbManual, btnBrowseManual,
                lblSzamla, tbSzamla, btnBrowseSzamla,
                lblNyelv, cbNyelv,
                btnAddOk, btnAddCancel
            });

            this.Controls.Add(panelHozzaad);
        }

        private void BtnBrowseKep_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Képek|*.jpg;*.png;*.bmp" };
            if (ofd.ShowDialog() == DialogResult.OK) tbKep.Text = ofd.FileName;
        }

        private void BtnBrowseManual_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF|*.pdf" };
            if (ofd.ShowDialog() == DialogResult.OK) tbManual.Text = ofd.FileName;
        }

        private void BtnBrowseSzamla_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "PDF|*.pdf" };
            if (ofd.ShowDialog() == DialogResult.OK) tbSzamla.Text = ofd.FileName;
        }

        private void BtnAddOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNev.Text))
            {
                MessageBox.Show("Adj nevet az eszköznek!");
                return;
            }

            Eszkoz uj = new Eszkoz()
            {
                Nev = tbNev.Text,
                Kep = tbKep.Text,
                ManualPdf = tbManual.Text,
                SzamlaPdf = tbSzamla.Text,
                ManualNyelv = cbNyelv.SelectedItem.ToString()
            };

            eszkozok.Add(uj);
            listBoxEszkozok.Items.Add(uj);

            tbNev.Text = tbKep.Text = tbManual.Text = tbSzamla.Text = "";
            cbNyelv.SelectedIndex = 0;
        }

        private void BtnAddCancel_Click(object sender, EventArgs e)
        {
            tbNev.Text = tbKep.Text = tbManual.Text = tbSzamla.Text = "";
            cbNyelv.SelectedIndex = 0;
        }
    }

    public class Eszkoz
    {
        public string Nev;
        public string Tipus;
        public string ManualPdf;
        public string ManualNyelv;
        public string SzamlaPdf;
        public string Kep;

    }
}
