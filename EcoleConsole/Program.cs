// See https://aka.ms/new-console-template for more information
using EcoleBusiness.DataModels;
using EcoleBusiness.Services;

Console.WriteLine("Hello, World!");

EcoleService ecolSrv = new EcoleService(1);

Console.WriteLine($"Bonjour ! Bienvenu à l'école {ecolSrv.MonEcole.Nom} !");
Console.WriteLine("Veuillez saisir le nom de l'élève à inscrire :");
var eleve = new Eleve();
eleve.EcoleId = ecolSrv.MonEcole.Id;
eleve.Nom = Console.ReadLine();
Console.WriteLine("Quel est son prénom");
eleve.Prenom = Console.ReadLine();
Console.WriteLine("Quelle est sa moyenne");
eleve.Moyenne = Convert.ToInt32(Console.ReadLine());

ecolSrv.Inscrire(eleve);

Console.WriteLine();
Console.WriteLine("Liste des élèves :");
ecolSrv.AfficherEleve();
Console.WriteLine();

Console.WriteLine("Liste du personnel :");
ecolSrv.AfficherPersonnel();


