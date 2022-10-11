// See https://aka.ms/new-console-template for more information
using PolymorphismeSurcharge;

Console.WriteLine("Hello, World!");

Vehicule vehicule = new VehiculeTerrestre();
VehiculeTerrestre vehicule1 = new VehiculeTerrestre();
Vehicule vehicule2 = new VehiculeMaritime();
//Vehicule vehicule3 = new Vehicule();

//string Klaxonner(Vehicule vehicule)
//{
//    if (vehicule is VehiculeTerrestre)
//    {
//        ((VehiculeTerrestre)vehicule).NombreRoue = 4;
//        vehicule.Nom = "Voiture";

//        return "Tutut";
//    }
//    else if(vehicule is VehiculeMaritime)
//    {
//        ((VehiculeMaritime)vehicule).NombreDeVoile = 2;
//        vehicule.Nom = "Bateau";
//        return "Pouet";
//    }
//    else
//    {
//        return "Tiiit";
//    }    
//}

Console.WriteLine(vehicule.Klaxonner());
Console.WriteLine(vehicule1.Klaxonner());
Console.WriteLine(vehicule2.Klaxonner());
//Console.WriteLine(vehicule3.Klaxonner());

vehicule.Demarrer();
vehicule1.Demarrer();
vehicule2.Demarrer();

Console.ReadLine();