namespace RO_ManualSoft
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox listBoxEszkozok;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnSzamla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNyelv;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxEszkozok = new System.Windows.Forms.ListBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnSzamla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNyelv = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxEszkozok
            // 
            this.listBoxEszkozok.ItemHeight = 16;
            this.listBoxEszkozok.Location = new System.Drawing.Point(20, 20);
            this.listBoxEszkozok.Name = "listBoxEszkozok";
            this.listBoxEszkozok.Size = new System.Drawing.Size(250, 292);
            this.listBoxEszkozok.TabIndex = 0;
            this.listBoxEszkozok.SelectedIndexChanged += new System.EventHandler(this.listBoxEszkozok_SelectedIndexChanged);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(300, 20);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(120, 30);
            this.btnManual.TabIndex = 3;
            this.btnManual.Text = "Kézikönyv";
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnSzamla
            // 
            this.btnSzamla.Location = new System.Drawing.Point(300, 60);
            this.btnSzamla.Name = "btnSzamla";
            this.btnSzamla.Size = new System.Drawing.Size(120, 30);
            this.btnSzamla.TabIndex = 4;
            this.btnSzamla.Text = "Számla";
            this.btnSzamla.Click += new System.EventHandler(this.btnSzamla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(300, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelNyelv
            // 
            this.labelNyelv.AutoSize = true;
            this.labelNyelv.Location = new System.Drawing.Point(300, 320);
            this.labelNyelv.Name = "labelNyelv";
            this.labelNyelv.Size = new System.Drawing.Size(0, 16);
            this.labelNyelv.TabIndex = 6;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(630, 20);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(848, 696);
            this.axAcroPDF1.TabIndex = 7;
            this.axAcroPDF1.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1564, 781);
            this.Controls.Add(this.listBoxEszkozok);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnSzamla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNyelv);
            this.Controls.Add(this.axAcroPDF1);
            this.Name = "Form1";
            this.Text = "RO ManualSoft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
