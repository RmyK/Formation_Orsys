// See https://aka.ms/new-console-template for more information

using GestionStock;

List<Article> arts = new List<Article>();

var y = 0;
while (true)
{
    try
    {

        var art = new Article();

        Console.WriteLine("Nom de l'article :");
        art.Nom = Console.ReadLine();
        Console.WriteLine("Prix de l'article");
        bool valOk = false;
        while (!valOk)
        {
            try
            {
                art.Prix = Convert.ToDecimal(Console.ReadLine());
                valOk = true;
            }
            catch (FormatException ex)
            {
                throw new SaisiePrixException("Le prix saisie n'est pas bon", ex);
            }
        }
        Console.WriteLine("Quantité de l'article");

        int.TryParse(Console.ReadLine(), out int i);
        art.Qte = i;

        Console.WriteLine("Prix total :" + art.Prix * art.Qte);
        Console.WriteLine("Prix total :{0}", art.Prix * art.Qte);
        Console.WriteLine($"Prix total :{art.Prix * art.Qte}");

        arts.Add(art);

        //string strConcat = "Article : " + art.Nom + " prix total = " + art.Prix * art.Qte;
        //string str = string.Format("Article {1}, prix total {0}", art.Nom, art.Prix * art.Qte);
        //string str2 = $"Article {art.Nom}, prix total {art.GetPrixTotal()}";

        ConsoleKeyInfo res;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Souhaitez-vous ajouter un nouvel article Y/N ?");
            res = Console.ReadKey();
            Console.WriteLine();
        } while (res.Key != ConsoleKey.Y && res.Key != ConsoleKey.N);
        if (res.Key == ConsoleKey.N)
            break;
    }
    catch (SaisiePrixException)
    {
        Console.WriteLine("Le prix doit être une valeur numérique");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Une exception a eu lieue, veuillez recommencer la saisie");
    }

}

foreach (Article article in arts)
{
    Console.WriteLine($"{article.Nom} - Prix total :{article.Prix * article.Qte}");
}

var rnd = new Random();
rnd.Next(100);