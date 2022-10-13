// See https://aka.ms/new-console-template for more information
using Linq;

Console.WriteLine("Hello, World!");

List<Article> articles = new List<Article>();
List<Personne> personnes = new List<Personne>();

var res = GetBy(articles, (a) => a.Prix > 100);
var res2 = GetBy2(articles, (a) => a.Prix > 100);

var res3 = GetBy2(personnes, (p) => p.Age > 18);

//var res4 = personnes.GetBy((p) => p.Age > 18);


List<Article> GetPrixSup100(List<Article> articles)
{
    List<Article> arts = new List<Article>();
    foreach (var article in articles)
    {
        if (article.Prix > 100)
        {
            arts.Add(article);
        }
    }

    return arts;
}

List<Article> GetPrixSup50(List<Article> articles)
{
    List<Article> arts = new List<Article>();
    foreach (var article in articles)
    {
        if (article.Prix > 50)
        {
            arts.Add(article);
        }
    }

    return arts;
}

List<Article> GetPrixSup(List<Article> articles, int prix)
{
    List<Article> arts = new List<Article>();
    foreach (var article in articles)
    {
        if (article.Prix > prix)
        {
            arts.Add(article);
        }
    }

    return arts;
}

List<Article> GetBy(List<Article> articles, Func<Article, bool> fct)
{
    List<Article> arts = new List<Article>();
    foreach (var article in articles)
    {
        if (fct(article))
        {
            arts.Add(article);
        }
    }

    return arts;
}


List<T> GetBy2<T>(List<T> items, Func<T, bool> fct)
{
    List<T> itms = new List<T>();
    foreach (var item in items)
    {
        if (fct(item))
        {
            itms.Add(item);
        }
    }

    return itms;
}

//static IEnumerable<T> GetBy3<T>(this IEnumerable<T> items, Func<T, bool> fct)
//{
//    foreach (var item in items)
//        if (fct(item))
//            yield return item;
//}