// See https://aka.ms/new-console-template for more information

using Delegue;

var tictac = new TicTac();

tictac.OnTic += AfficherTac;

Console.WriteLine("Hello, World!");

Console.WriteLine("Quelle opération");
Console.WriteLine("1/Addition 2/Soustration 3/Division 4/Multiplication");
var choix = Console.ReadLine();

//Operation ope = null;
Func<int, int, double> ope = null;

switch (choix)
{
    case "1":
        //ope = Addition; break;
        ope = (a, b) => { return a + b; };
        tictac.OnTic -= AfficherTac;
        break;
    case "2":
        //ope = Soustraction; break;
        ope = (a, b) => { return a - b; }; break;
    case "3":
        //ope = Division; break;
        ope = (a, b) => { return a / b; }; break;
    case "4":
        //ope = Multiplication; break;
        ope = (a, b) => { return a * b; }; break;

    default:
        break;
}

Console.WriteLine("Valeur de A");
var a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Valeur de B");
var b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ope(a, b));

//double Addition(int a, int b)
//{
//    return a + b;
//}

//double Soustraction(int a, int b)
//{
//    return a - b;
//}

//double Division(int a, int b)
//{
//    return a / b;
//}

//double Multiplication(int a, int b)
//{
//    return a * b;
//}


//public delegate double Operation(int a, int b);

void AfficherTac(object? sender, EventArgs args)
{
    Console.WriteLine(((TicTac)sender).GetI());
}
