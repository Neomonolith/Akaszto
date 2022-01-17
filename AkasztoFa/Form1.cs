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
  
  public partial class Form1 : Form
  {
    List<Adatok> lista = new List<Adatok>();

    public Form1()
    {
      InitializeComponent();
      Beolvas();
      Elso();
      Nehezseg();
    }

    private void Nehezseg()
    {
      /*
      * konnyu count >= 8
      * kozepes count <=6
      * nehez count <=4
      * 
      */

      if (rbKonnyu.Checked == true)
      {
        rbKozepes.Enabled = false;
        rbNehez.Enabled = false;

       


      }
      if (rbKozepes.Checked == true)
      {
        rbKonnyu.Enabled = false;
        rbNehez.Enabled = false;
      }
      if (rbNehez.Checked == true)

      {
        
        rbKonnyu.Enabled = false;
        rbKozepes.Enabled = false;
      }

    }

    public void Elso()
    {
    


      Random rand = new Random();
   
      int index = rand.Next(lista.Count);
 
      String KitalalandoSzo = lista[index].Szavak;
       
      int count = 0;
      foreach (char c in KitalalandoSzo)
      {
        count++;
     
      }
   
      int x = 0;
      while (x < count)
      {
        lblKitalalando.Text += "_ ";
        x++;
      }


     char[] characters = KitalalandoSzo.ToCharArray();



      //TESZTEK  DIK
      lblTESZT.Text = Convert.ToString( characters[0]);
      lblTESZT3.Text = Convert.ToString(characters.Last());
      lblTESZT2.Text = KitalalandoSzo;
      //TESZTEK VÉGE


     
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

    private void btnFeladas_Click(object sender, EventArgs e)
    {

    }

    private void gbNehezseg_Enter(object sender, EventArgs e)
    {

    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        MessageBox.Show("Enter key pressed");
        
      }
    }
  }
}
