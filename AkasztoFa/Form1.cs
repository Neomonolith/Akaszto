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

namespace AkasztoFa
{
  
  public partial class Form1 : Form
  {
    List<Adatok> lista = new List<Adatok>();

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
        lista.Add(new Adatok(a[0]));
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
      this.pcAkasztofa.Image = AkasztoFa.Properties.Resources._Kezdo;
      lblKitalalando.Text = "";
      lblFelhasznaltak.Text = "";
      lblProbaszam.Text = "0";

      rbKonnyu.Checked = false;
      rbKozepes.Checked = false;
      rbNehez.Checked = false;
    }
  }
}
