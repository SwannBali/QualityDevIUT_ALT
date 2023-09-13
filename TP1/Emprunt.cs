using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Emprunt
{

    private bool rendu;
    private string adressemailEmprunteur;
    private DateTime DateEmprunt;
    private DateTime DateRetour;
    private Media _media;

    public bool Rendu
    {
        get { return rendu; }
        set { rendu = value; }
    }

    public Media Media
    {
          get { return _media; }
    }

    public Emprunt(bool rendu, string adressemailEmprunteur, DateTime dateEmprunt, DateTime dateRetour, Media media)
    {
        this.rendu = rendu;
        this.adressemailEmprunteur = adressemailEmprunteur;
        DateEmprunt = dateEmprunt;
        DateRetour = dateRetour;
        _media = media;
    }


}
