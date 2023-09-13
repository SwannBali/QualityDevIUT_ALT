using System.Runtime.CompilerServices;

public class Media
{

    private string Titre;
    private int Reference;
    protected int NombreExemplaires;

    public Media(string titre, int reference, int nombreExemplaires)
    {
        Titre = titre;
        Reference = reference;
        NombreExemplaires = nombreExemplaires;
    }
    public Media() { }


    public static Media operator +(Media media, int nombreExemplaires)
    {

        media.NombreExemplaires += nombreExemplaires;
        return media;
    }

    public int reference
    {
        get { return Reference; }
    }

    public int nombreExemplaires
    {
        get { return NombreExemplaires; }
        set { Reference = value; }
    }

    public static Media operator -(Media media, int nombreExemplaires)
    {
        if(media.NombreExemplaires - nombreExemplaires < 0)
        {
            throw new System.ArgumentException("Nombre d'exemplaires insuffisant");
        }
        else if (media.NombreExemplaires - nombreExemplaires == 0)
        {
            media.NombreExemplaires = 0;
        }
        else
        {
            media.NombreExemplaires -= nombreExemplaires;
        }


        return media;
        
    }

    public virtual void AfficherInfo()
    {
        Console.WriteLine("Titre : " + Titre);
        Console.WriteLine("Reference : " + Reference);
        Console.WriteLine("Nombre d'exemplaires : " + NombreExemplaires);
    }

}


public class Livre : Media
{
    private string auteur; 


    public Livre() { }

    public Livre(string titre, int reference, int nombreExemplaires, string auteur) : base(titre, reference, nombreExemplaires)
    {
        this.auteur = auteur;
    }


    public override void AfficherInfo()
    {
        base.AfficherInfo();
        Console.WriteLine("Auteur : " + auteur);
    }

}

public class DVD : Media
{

    private int duree;

    public DVD() { }

    public DVD(string titre, int reference, int nombreExemplaires, int duree) : base(titre, reference, nombreExemplaires)
    {
        this.duree = duree;
    }

    public override void AfficherInfo()
    {
        base.AfficherInfo();
        Console.WriteLine("Duree : " + duree);
    }

}

public class CD : Media
{

    private string Artiste;

    public CD() { }

    public CD(string titre, int reference, int nombreExemplaires, string artiste) : base(titre, reference, nombreExemplaires)
    {
        Artiste = artiste;
    }

    public override void AfficherInfo()
    {
        base.AfficherInfo();
        Console.WriteLine("Artiste : " + Artiste);
    }

}

public class Tools
{

}
