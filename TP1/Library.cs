using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Library
{

    private List<Media> medias = new List<Media>();
    private List<Emprunt> emprunts = new List<Emprunt>();

    public Media this[int reference]
    {

        get
        {
            if(medias.Exists(x => x.reference == reference))
            {
                return medias.Find(x => x.reference == reference);
            }
            else
            {
                throw new System.ArgumentException("Reference introuvable");
            }
        }

    }

    public void AddMedia(Media media)
    {
        medias.Add(media);
    }

    public void deleteMedia(Media media)
    {
        medias.Remove(media);
    }

    public void Emprunter(Media media, string adresseMailEmprunteur)
    {

        if (this[media.reference].nombreExemplaires == 0)
        {
            throw new System.ArgumentException("Nombre d'exemplaires insuffisant");
        }
        else
        {
            Emprunt emprunt = new Emprunt(false, adresseMailEmprunteur, DateTime.Now, DateTime.Now.AddDays(7), media);
            emprunts.Add(emprunt);
            this[media.reference].nombreExemplaires--;
        }

        

    }

    public void Rendre(Media media)
    {
        if (emprunts.Exists(x => x.Media.reference == media.reference))
        {
            emprunts.Find(x => x.Media.reference == media.reference).Rendu = true;
            this[media.reference].nombreExemplaires++;
        }
        else
        {
            throw new System.ArgumentException("Media non emprunté");
        }
    }

}
