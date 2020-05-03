using System;
using System.Collections.Generic;




class studentas 
{
  public string vardas {get; set;}
  public string pavarde {get; set;}
  public int egz {get; set;}
  public double vid {get; set;}
  public double med {get; set;}

  public List<int> nd = new List<int>();
  public double vidurkis {get; set;}=0;

  public studentas (string vardas, string pavarde, int egz, List<int> nd)
  {
    this.vardas=vardas;
    this.pavarde=pavarde;
    this.egz=egz;
    this.nd=nd;
    foreach (int sk in this.nd)
    {
      this.vidurkis = this.vidurkis + sk;
    }
    this.vidurkis = this.vidurkis / this.nd.Count;
    this.vid = this.vidurkis * 0.3 + this.egz * 0.7;
    
    this.nd.Sort();
    this.med = this.nd[this.nd.Count/2] * 0.3 + this.egz * 0.7;
  }


}