using PDF;

// Instanciation d'une poule Ginger,Hamza et Shawn
Poule ginger = new Poule("Ginger", "gauloise", 0.8, Taille.L);
Poule Hamza = new Poule("Hamza", "sussex", 1.8, Taille.XXL);

// Affichage de cette poule
ginger.Afficher();

Poulailler Ophelia = new Poulailler("Ophelia", 6);

//Affichage du poulailler
Ophelia.afficherPoulailler();

Ophelia.AjouterPoule(Hamza);
Ophelia.afficherPoulailler();

Poule Shawn = new Poule("Shawn", "gauloise", 0.8, Taille.M);

// Ajout de la poule Shawn dans le poulailler d'Ophelia et affichage du poulailler
Ophelia.AjouterPoule(Shawn);
Ophelia.afficherPoulailler();

//Supression de la poule Shawn du poulailler d'Ophelia et affichage du poulailler
Ophelia.SupprimerPoule(2);
Ophelia.afficherPoulailler();