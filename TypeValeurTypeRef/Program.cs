// See https://aka.ms/new-console-template for more information
using TypeValeurTypeRef;

Console.WriteLine("Hello, World!");

var p = new Personne() { Nom = "Mobil", Prenom = "Otto" };
var p1 = new Personne() { Nom = "Sion", Prenom = "Eva" };
int i = 5;

ChangePrenom(p,ref i);
//"with {}" va permettre de copier à l'identique une instance d'un record = nouvelle instance avec
//les mêmes valeurs du record
ChangePrenom(p1 with {},ref i);

Console.WriteLine(p.Prenom);
Console.WriteLine(p1.Prenom);
Console.WriteLine(i);

//ref force le passage par ref d'un type valeur.=> si la méthode modifie la référence,
//la valeur est aussi modifier dans le reste du code
void ChangePrenom(Personne personne, ref int i)
{
    personne.Prenom = "Jean";
    Console.WriteLine(i);
    i = 12;
}