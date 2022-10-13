// See https://aka.ms/new-console-template for more information
using DirectiveEtAttribut;
using System.ComponentModel;
using System.Reflection;

Console.WriteLine("Hello, World!");

#if MADIRECTIVE

Console.WriteLine("Hello en mode Debug");

#endif

#if MADIRECTIVERELEASE
Console.WriteLine("Hello en mode Release");
#endif

Console.WriteLine(typeof(ClasseDeTest).GetProperty(nameof(ClasseDeTest.MyString)).GetCustomAttribute<NouvelAttribut>().NomAttribut);

//Console.WriteLine(typeof(EFonctionEmployer).GetMember(EFonctionEmployer.EmployerTri.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>().Description);
Console.WriteLine(EFonctionEmployer.EmployerTri.GetDescription());