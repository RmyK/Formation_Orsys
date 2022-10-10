// See https://aka.ms/new-console-template for more information

using GestionStock;

var art = new Article();

Console.WriteLine("Nom de l'article :");
art.Nom = Console.ReadLine();
Console.WriteLine("Prix de l'article");
art.Prix = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Quantité de l'article");

int.TryParse(Console.ReadLine(), out int i);
art.Qte = i;

Console.WriteLine("Prix total :" + art.Prix * art.Qte);
Console.WriteLine("Prix total :{0}", art.Prix * art.Qte);
Console.WriteLine($"Prix total :{art.Prix * art.Qte}");
string strConcat = "Article : " + art.Nom + " prix total = " + art.Prix * art.Qte;
string str = string.Format("Article {1}, prix total {0}", art.Nom, art.Prix * art.Qte);
string str2 = $"Article {art.Nom}, prix total {art.GetPrixTotal()}";
