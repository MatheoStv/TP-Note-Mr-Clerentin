namespace PDF;

public class Poulailler
{
    /// <summary>
    /// Nom du poulailler
    /// </summary>
    /// <example>PoulaillerZ2X, Poulailler de l'IUT</example>
    string nom;
    /// <summary>
    /// Capacité du Poulet
    /// </summary>
    /// <example>50,12,78</example>
    int capacite;
    /// <summary>
    /// liste des poules
    /// </summary>
    /// <example>Romain,Tristan</example>
    List<Poule> ListePoules;

    /// <summary>
    /// Création d'une nouvelle instance d'un objet Poulailler
    /// </summary>
    /// <param name="nomPoulailler">nom</param>
    /// <param name="capaciteMax">capacite</param>

    public Poulailler(string nomPoulailler, int capaciteMax)
    {
        nom = nomPoulailler;
        capacite = capaciteMax;
        ListePoules = new List<Poule>();
    }
    /// <summary>
    /// Ajoute une poule dans le poulailler
    /// </summary>
    public void AjouterPoule(Poule poule)
    {
        if (ListePoules.Count == capacite)
        {
            Console.WriteLine($"Capacité max du poulailler atteinte\n");
        }
        else
        {
            ListePoules.Add(poule);
        }
    }

    /// <summary>
    /// Affiche toutes les poules d'un poulailler et le nombre total de poule dans le poulailler
    /// </summary>
    public void afficherPoulailler()
    {
        int numPoules = 0;
        foreach (Poule poule in ListePoules)
        {
            numPoules++;
            Console.WriteLine($"{numPoules} : ");
            poule.Afficher();
        }
        Console.WriteLine($"Il y a {numPoules} poule sur {capacite} dans le poulailler {nom} ");
    }
    /// <summary>
    /// Supprimer une poule du poulailler à partir de son numéro 
    /// </summary>
    public void SupprimerPoule(int numPoule)
    {
        if (numPoule > ListePoules.Count)
        {
            Console.WriteLine($"Il n'y a pas de poule n° {numPoule} dans le poulailler\n");
        }
        else
        {
            ListePoules.RemoveAt(numPoule - 1);
        }
    }

    public void MoyennePonte()
    {
        double SommeIntensitePonte = 0;
        foreach (Poule poule in ListePoules)
        {
            SommeIntensitePonte += poule.IntensitePonte;
        }
        Console.WriteLine($"La moyenne d'intensité de ponte est de {Math.Round(SommeIntensitePonte/ListePoules.Count,1)}");
    }

}