using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AkasztoFa
{
  enum Allapot
  {
    Nincsjatek,
    Jatek,
    Feladas
  }
  public partial class Form1 : Form
  {
    List<string> lista = new List<string>();
    List<string> eddighasznaltBetuk;
    int pontok;
    int probaszam;
    string szokitoltve;
    string velszo;
    Allapot allapot;
    public Form1()

      
    {
      InitializeComponent();
      Beolvas();
      
    }

   

    private void Beolvas()
    {

      StreamReader be = new StreamReader("dikaTXT.txt");

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        lista.Add(a[0]);
      }

      be.Close();


    }

    private void Form1_Shown(object sender, EventArgs e)
    {

    }

    private void btnKilep_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnUj_Click(object sender, EventArgs e)
    {
      allapot = Allapot.Jatek;
      this.pcAkasztofa.Image = AkasztoFa.Properties.Resources._Kezdo;
      lblKitalalando.Text = "";
      lblFelhasznaltak.Text = "";
      lblProbaszam.Text = "10";
      probaszam = 10;
      rbKonnyu.Checked = false;
      rbKozepes.Checked = false;
      rbNehez.Checked = false;
      Veletlenszovalasztas();
      SzoMegjelenites();

      lblInformacio.Text = $"A kitalálandó szó: ({velszo.Length} betű)";
      btnFeladas.Enabled = true;
      btnKilep.Enabled = false;
      btnUj.Enabled = true;
  eddighasznaltBetuk = new List<string>();
    }

    private void SzoMegjelenites()
    {
      lblKitalalando.Text = "";
      string szokitoltve = "";
      int hossz = velszo.Length * 2;
      for (int i = 0; i < hossz; i++)
      {
        if (i % 2 == 0)
        {
          szokitoltve += "_";
        }
        else
        {
          szokitoltve += " ";
        }

      }
      lblKitalalando.Text = szokitoltve;
    }

    private void Veletlenszovalasztas()
    {

      Random vel = new Random(Guid.NewGuid().GetHashCode());
      // velszo = lista[vel.Next(lista.Count)];
     
      velszo = lista[vel.Next(lista.Count)];

      

    }

    private void btnFeladas_Click(object sender, EventArgs e)
    {

    }

    

    

     void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (allapot == Allapot.Jatek && Char.IsLetter(e.KeyChar))
      {
        if (!eddighasznaltBetuk.Contains(Convert.ToString( e.KeyChar)))
        {


          eddighasznaltBetuk.Add((e.KeyChar).ToString().ToLower());
          // lblFelhasznaltak.Text += ((e.KeyChar).ToString().ToLower());

          HasznaltBetukKiirasa();

          TalaltBetukMegjelenitese(e.KeyChar.ToString());
        }
        else
        {
          MessageBox.Show("Ez a betű műr bent van", "Figyelem", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
      }
    }

    private void TalaltBetukMegjelenitese(string betu)
    {
      int hely = 0;
      if (probaszam <= 10)
      {


        if (velszo.Contains(betu))
        { 
          szokitoltve.Replace(Convert.ToChar(betu),'_');
        }
        else
        {
          probaszam--;
        }

      }


      if (velszo[ve])
      {

      }
      

      
      

      
    }

    private void HasznaltBetukKiirasa()
    {
      lblFelhasznaltak.Text += String.Join(",",eddighasznaltBetuk);
    }

   
  }
}
