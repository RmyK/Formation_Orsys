// See https://aka.ms/new-console-template for more information
using ModifAcces;

Console.WriteLine("Hello, World!");

var bateau = new BateauAVoile();
var avion = new Avion();
var voiture = new Voiture();

var reparateur = new Reparateur();

//reparateur.EntretenirVehiculeAMoteur(bateau);
reparateur.EntretenirVehiculeAMoteur(avion);
reparateur.EntretenirVehiculeAMoteur(voiture);

Console.Read();