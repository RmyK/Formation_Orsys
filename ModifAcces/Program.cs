// See https://aka.ms/new-console-template for more information
using ModifAcces;

Console.WriteLine("Hello, World!");

var bateau = new BateauAVoile();
var avion = new Avion();
var voiture = new Voiture();

var reparateur = new Reparateur();

var charAVoile = new CharAVoile() { Proprietaire ="M. Jean", NombreDeVoile = 2 };
var charAVoile2 = new CharAVoile() { Proprietaire = "M. Jean", NombreDeVoile = 2 };
var charAVoile3 = charAVoile;

var isEquals = charAVoile == charAVoile3; // true
var isEquals2 = charAVoile == charAVoile2; // false
var isEquals3 = charAVoile.Equals(charAVoile3); //true;
var hash = charAVoile.GetHashCode();
var hash2 = charAVoile2.GetHashCode();
var isEquals4 = object.Equals(charAVoile, charAVoile2);

Console.WriteLine(isEquals);
Console.WriteLine(isEquals2);
Console.WriteLine(isEquals3);
Console.WriteLine(isEquals4);
Console.WriteLine(hash);
Console.WriteLine(hash2);


//reparateur.EntretenirVehiculeAMoteur(bateau);
reparateur.EntretenirVehiculeAMoteur(avion);
reparateur.EntretenirVehiculeAMoteur(voiture);

Console.Read();

