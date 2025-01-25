using Csharquarium.Models;
using Csharquarium.Models.Poissons;

Aquarium a = new Aquarium();
int AfficherMenu()
{ 
Console.WriteLine("Bienvenue dans le Csharquarium !");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Que voulez-vous faire ?");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Tapez 1 pour ajouter un poisson \nTapez 2 pour ajouter une algue \nTapez 3 pour passer une journée");
Console.WriteLine("Choix : ");

return Convert.ToInt32(Console.ReadLine());
}

int choix = -1;

while (choix != 0) { 

    if (choix == 1)
    {
        a.AjouterPoisson(new Poisson());
    }
    //else if (choix == 2)
    //    {
    //    a.AjouterAlgue(new algue);
    //}
    //else if (choix == 3)
    //    {
    //    a.PasserJournee();
    //}
}

Console.WriteLine();
