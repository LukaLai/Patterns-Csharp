// Exemple d'utilisation
using TP;

Livres livre = new Livres();
Client client = new Client();
Commande commande = new Commande();


// Création de livres
Livres livre1 = new Livres("Livre 1", "Auteur 1", "Categorie 1", "Langue 1", "29/11/2023");
Livres livre2 = new Livres("Livre 2", "Auteur 2", "Categorie 2", "Langue 2", "28/11/2023");

//Ajout client
Client client1 = new Client("Client 1", "Paul", "Paris", "94000", "paul@azerty.fr");
Client client2 = new Client("Client 2", "Pierre", "Lyon", "69000", "pierre@azerty.fr");

commande.AjouterCommande("n°1", "29/11/2023", "FR", client2, livre1);