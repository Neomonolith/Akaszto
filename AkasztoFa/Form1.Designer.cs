
namespace AkasztoFa
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.lblKitalalando = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblProbaszam = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblFelhasznaltak = new System.Windows.Forms.Label();
      this.btnUj = new System.Windows.Forms.Button();
      this.btnFeladas = new System.Windows.Forms.Button();
      this.btnKilep = new System.Windows.Forms.Button();
      this.gbNehezseg = new System.Windows.Forms.GroupBox();
      this.rbNehez = new System.Windows.Forms.RadioButton();
      this.rbKozepes = new System.Windows.Forms.RadioButton();
      this.rbKonnyu = new System.Windows.Forms.RadioButton();
      this.pcAkasztofa = new System.Windows.Forms.PictureBox();
      this.lblInformacio = new System.Windows.Forms.Label();
      this.gbNehezseg.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcAkasztofa)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Kitalálandó szó";
      // 
      // lblKitalalando
      // 
      this.lblKitalalando.AutoSize = true;
      this.lblKitalalando.Location = new System.Drawing.Point(52, 64);
      this.lblKitalalando.Name = "lblKitalalando";
      this.lblKitalalando.Size = new System.Drawing.Size(0, 20);
      this.lblKitalalando.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(961, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(160, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Próbálozások száma:";
      // 
      // lblProbaszam
      // 
      this.lblProbaszam.AutoSize = true;
      this.lblProbaszam.Location = new System.Drawing.Point(1127, 32);
      this.lblProbaszam.Name = "lblProbaszam";
      this.lblProbaszam.Size = new System.Drawing.Size(18, 20);
      this.lblProbaszam.TabIndex = 0;
      this.lblProbaszam.Text = "0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(52, 265);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(208, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "Már felhasznált lehetőségek";
      // 
      // lblFelhasznaltak
      // 
      this.lblFelhasznaltak.AutoSize = true;
      this.lblFelhasznaltak.Location = new System.Drawing.Point(52, 302);
      this.lblFelhasznaltak.Name = "lblFelhasznaltak";
      this.lblFelhasznaltak.Size = new System.Drawing.Size(24, 20);
      this.lblFelhasznaltak.TabIndex = 0;
      this.lblFelhasznaltak.Text = "---";
      // 
      // btnUj
      // 
      this.btnUj.Location = new System.Drawing.Point(56, 612);
      this.btnUj.Name = "btnUj";
      this.btnUj.Size = new System.Drawing.Size(103, 36);
      this.btnUj.TabIndex = 2;
      this.btnUj.Text = "Új Játék";
      this.btnUj.UseVisualStyleBackColor = true;
      this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
      // 
      // btnFeladas
      // 
      this.btnFeladas.Location = new System.Drawing.Point(306, 612);
      this.btnFeladas.Name = "btnFeladas";
      this.btnFeladas.Size = new System.Drawing.Size(103, 36);
      this.btnFeladas.TabIndex = 2;
      this.btnFeladas.Text = "Feladás";
      this.btnFeladas.UseVisualStyleBackColor = true;
      this.btnFeladas.Click += new System.EventHandler(this.btnFeladas_Click);
      // 
      // btnKilep
      // 
      this.btnKilep.Location = new System.Drawing.Point(576, 612);
      this.btnKilep.Name = "btnKilep";
      this.btnKilep.Size = new System.Drawing.Size(103, 36);
      this.btnKilep.TabIndex = 2;
      this.btnKilep.Text = "Kilépés";
      this.btnKilep.UseVisualStyleBackColor = true;
      this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
      // 
      // gbNehezseg
      // 
      this.gbNehezseg.Controls.Add(this.rbNehez);
      this.gbNehezseg.Controls.Add(this.rbKozepes);
      this.gbNehezseg.Controls.Add(this.rbKonnyu);
      this.gbNehezseg.Location = new System.Drawing.Point(56, 369);
      this.gbNehezseg.Name = "gbNehezseg";
      this.gbNehezseg.Size = new System.Drawing.Size(200, 147);
      this.gbNehezseg.TabIndex = 4;
      this.gbNehezseg.TabStop = false;
      this.gbNehezseg.Text = "Nehézség";
      // 
      // rbNehez
      // 
      this.rbNehez.AutoSize = true;
      this.rbNehez.Location = new System.Drawing.Point(56, 91);
      this.rbNehez.Name = "rbNehez";
      this.rbNehez.Size = new System.Drawing.Size(73, 24);
      this.rbNehez.TabIndex = 4;
      this.rbNehez.TabStop = true;
      this.rbNehez.Text = "Nehéz";
      this.rbNehez.UseVisualStyleBackColor = true;
      // 
      // rbKozepes
      // 
      this.rbKozepes.AutoSize = true;
      this.rbKozepes.Location = new System.Drawing.Point(56, 61);
      this.rbKozepes.Name = "rbKozepes";
      this.rbKozepes.Size = new System.Drawing.Size(89, 24);
      this.rbKozepes.TabIndex = 5;
      this.rbKozepes.TabStop = true;
      this.rbKozepes.Text = "Közepes";
      this.rbKozepes.UseVisualStyleBackColor = true;
      // 
      // rbKonnyu
      // 
      this.rbKonnyu.AutoSize = true;
      this.rbKonnyu.Location = new System.Drawing.Point(56, 31);
      this.rbKonnyu.Name = "rbKonnyu";
      this.rbKonnyu.Size = new System.Drawing.Size(80, 24);
      this.rbKonnyu.TabIndex = 6;
      this.rbKonnyu.TabStop = true;
      this.rbKonnyu.Text = "Könnyű";
      this.rbKonnyu.UseVisualStyleBackColor = true;
      // 
      // pcAkasztofa
      // 
      this.pcAkasztofa.Image = global::AkasztoFa.Properties.Resources._Kezdo;
      this.pcAkasztofa.Location = new System.Drawing.Point(477, 157);
      this.pcAkasztofa.Name = "pcAkasztofa";
      this.pcAkasztofa.Size = new System.Drawing.Size(633, 371);
      this.pcAkasztofa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pcAkasztofa.TabIndex = 1;
      this.pcAkasztofa.TabStop = false;
      // 
      // lblInformacio
      // 
      this.lblInformacio.AutoSize = true;
      this.lblInformacio.Location = new System.Drawing.Point(52, 12);
      this.lblInformacio.Name = "lblInformacio";
      this.lblInformacio.Size = new System.Drawing.Size(51, 20);
      this.lblInformacio.TabIndex = 6;
      this.lblInformacio.Text = "label4";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1200, 692);
      this.Controls.Add(this.lblInformacio);
      this.Controls.Add(this.gbNehezseg);
      this.Controls.Add(this.btnKilep);
      this.Controls.Add(this.btnFeladas);
      this.Controls.Add(this.btnUj);
      this.Controls.Add(this.pcAkasztofa);
      this.Controls.Add(this.lblKitalalando);
      this.Controls.Add(this.lblProbaszam);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblFelhasznaltak);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Analfabéta Akasztófa 0.1";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
      this.gbNehezseg.ResumeLayout(false);
      this.gbNehezseg.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcAkasztofa)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblKitalalando;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblProbaszam;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblFelhasznaltak;
    private System.Windows.Forms.PictureBox pcAkasztofa;
    private System.Windows.Forms.Button btnUj;
    private System.Windows.Forms.Button btnFeladas;
    private System.Windows.Forms.Button btnKilep;
    private System.Windows.Forms.GroupBox gbNehezseg;
    private System.Windows.Forms.RadioButton rbNehez;
    private System.Windows.Forms.RadioButton rbKozepes;
    private System.Windows.Forms.RadioButton rbKonnyu;
    private System.Windows.Forms.Label lblInformacio;
  }
}

