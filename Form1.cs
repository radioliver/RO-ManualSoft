using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RO_ManualSoft
{
    public partial class Form1 : Form
    {
        PictureBox pb = new PictureBox();
        Button pdf = new Button();
        Button szamla = new Button();
        AxAcroPDFLib.AxAcroPDF reader = new AxAcroPDFLib.AxAcroPDF();

        public Form1()
        {
            InitializeComponent();
            pdf.Visible = false;
            szamla.Visible = false;
            pdf.Visible = false;
            pdf.Click += Pdf_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void egyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void osmoPocket3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdf.Text = "Kézikönyv";
            pdf.Location = new Point(50, 400);

            this.Controls.Add(pdf);
            pdf.Visible = true;
            szamla.Text = "Számla";
            szamla.Location = new Point(170, 580);
            szamla.Visible = true;
            this.Controls.Add(szamla);
            pb.Image = Image.FromFile($"{osmoPocket3ToolStripMenuItem.Text}.jpeg");
            pb.Location = new Point(50, 150);
            pb.Visible = true;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(400, 400);
            this.Controls.Add(pb);


        }
        private void Pdf_Click(object sender, EventArgs e)
        {
            reader.Visible = true;
            reader.Location = new Point(500, 50);
            reader.Size = new Size(1400, 900);
            this.Controls.Add(reader);
            reader.LoadFile($"Osmo Pocket 3.pdf");
        }
    }
}
