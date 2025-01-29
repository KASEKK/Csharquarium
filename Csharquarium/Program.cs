using Csharquarium.Models;
using Csharquarium.Models.Poissons;


// Création de l'aquarium
Aquarium a = new Aquarium();

// Fonction pour afficher le menu
int AfficherMenu()
{ 
Console.WriteLine("Bienvenue dans le Csharquarium !");
Console.WriteLine("*************************************************");
Console.WriteLine("\n");
Console.WriteLine("Que voulez-vous faire ?");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Tapez 1 pour ajouter un poisson \nTapez 2 pour ajouter une algue \nTapez 3 pour passer une journée");
    Console.WriteLine("\n");
    Console.Write("Choix : ");

return Convert.ToInt32(Console.ReadLine());
}

int choix = -1;
// Boucle pour afficher le menu et lancer la vie de l'aquarium
while (choix != 0) {
    Console.WriteLine("*************************************************");
    choix = AfficherMenu();

    if (choix == 1)
    {
        // Ajout d'un poisson a l'aquarium
        Console.WriteLine("Veuillez entrer le nom du poisson : ");
        string? nom = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("Veuillez entrer le sexe du poisson (M/F) : ");
        string? sexeInput = Console.ReadLine();

        if (!string.IsNullOrEmpty(nom) && !string.IsNullOrEmpty(sexeInput) && sexeInput.Length == 1)
        {
            char sexe = sexeInput[0];
            a.Ajouter(new Poisson(nom, sexe));
            Console.WriteLine("Poisson ajouté avec succès ! Voici la liste des êtres vivants dans l'aquarium : ");
            Console.WriteLine("\n");
            a.AfficherEtreVivant();
        }
        else
        {
            Console.WriteLine("Entrée invalide pour le nom ou le sexe du poisson.");
            Console.WriteLine("\n");
        }
       
    }
    else if (choix == 2)
    {
        // Ajout d'une algue
        Console.WriteLine("Veuillez entrer l'âge de la nouvelle algue : ");
        int age = Convert.ToInt32(Console.ReadLine());
        Algue nouvelleAlgue = new Algue(age);
        a.AjouterAlgue(nouvelleAlgue);
        Console.WriteLine("\n");
        Console.WriteLine("Algue ajoutée avec succès ! Voici la liste des êtres vivants dans l'aquarium : ");
        a.AfficherEtreVivant();
    }
    else if (choix == 3)
    {
        // Passer une journée
        a.PasserLeTemps();
        Console.WriteLine("\n");
        Console.WriteLine("Une journée est passée dans l'aquarium. Voici la liste des êtres vivants dans l'aquarium : ");
        a.AfficherEtreVivant();
    }
    else
    {
        Console.WriteLine("Choix invalide. Veuillez réessayer.");
    }


}
