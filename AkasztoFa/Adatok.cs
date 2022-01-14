using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
