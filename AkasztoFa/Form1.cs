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
  class Adatok
  {

    private string szavak;

    public string Szavak
    {
      get { return szavak; }
      set { szavak = value; }
    }

    public Adatok(string szavak)
    {
      this.szavak = szavak;
    }
  }
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
  }
}
