// Exemple d'utilisation
using TP;

Livres livre = new Livres();
Client client = new Client();
Commande commande = new Commande();


// Création de livres
Livres livre1 = new Livres("Livre 1", "Auteur 1", "Categorie 1", "Langue 1", "29/11/2023");
Livres livre2 = new Livres("Livre 2", "Auteur 2", "Categorie 2", "Langue 2", "28/11/2023");

List<Livres> listeLivres = new List<Livres> { livre1, livre2 };


//Ajout client
Client client1 = new Client("Client 1", "Paul", "Paris", "94000", "paul@azerty.fr");
Client client2 = new Client("Client 2", "Pierre", "Lyon", "69000", "pierre@azerty.fr");

List<Client> listeClients = new List<Client> { client1, client2 };



Livres.ListerLivres(listeLivres);

// Demander à l'utilisateur s'il veut créer un client
Console.Write("Voulez-vous créer un client? (Oui/Non): ");
string reponse = Console.ReadLine();

if (reponse.ToLower() == "oui")
{
    // Demander les informations du client à l'utilisateur
    Console.Write("Nom du client: ");
    string nom = Console.ReadLine();

    Console.Write("Prénom du client: ");
    string prenom = Console.ReadLine();

    Console.Write("Ville du client: ");
    string adresse = Console.ReadLine();

    Console.Write("Code postal du client: ");
    string codePostal = Console.ReadLine();

    Console.Write("Email du client: ");
    string email = Console.ReadLine();

    // Créer un objet Client et l'ajouter à la liste
    Client nouveauClient = new Client(nom, prenom, adresse, codePostal, email);
    listeClients.Add(nouveauClient);

    //Demander liste clients
    Console.WriteLine("Voulez-vous voir la liste de tout les clients ? (oui/non): ");
    reponse = Console.ReadLine();
    if (reponse.ToLower() == "oui")
    {
        Client.ListerClients(listeClients);
    }
}
else
{
    Console.WriteLine("Voici la liste des clients existants");
    Client.ListerClients(listeClients);
}

//Demander creation commande
Console.WriteLine("Voulez-vous creer une nouvelle commande ? (oui/non): ");
reponse = Console.ReadLine();
if (reponse.ToLower() == "oui")
{
    Console.WriteLine("Nom de la commande: ");
    string NomCommande = Console.ReadLine();
    Console.WriteLine("Langue de la commande: ");
    string LangueCommande = Console.ReadLine();
    Console.WriteLine("Taper le titre du livre pour la commande: ");
    string TitreLivre = Console.ReadLine();
    Livres livreAssocie = listeLivres.Find(l => l.Titre == TitreLivre);
    Console.WriteLine("Taper le nom du client pour la commande: ");
    string NomClient = Console.ReadLine();
    Client clientAssocie = listeClients.Find(c => c.Nom == NomClient);


    commande.AjouterCommande(NomCommande, "29/11/2023", LangueCommande, clientAssocie, livreAssocie);
}




//commande.AjouterCommande("n°1", DateTime.now, "FR", client2, livre1);