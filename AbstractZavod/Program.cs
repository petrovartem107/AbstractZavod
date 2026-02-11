using AbstractZavod;

ChainikovZavod chainikovZavod = new ChainikovZavod();
HolodilnikovZavod holodilnikovZavod = new HolodilnikovZavod();
Kavaz kavaz = new Kavaz();
Fabrica fabrica = new Fabrica();

kavaz.Proizvodit();
holodilnikovZavod.Proizvodit();
chainikovZavod.Proizvodit();
fabrica.Realization();

IPredpiyatie kavazPredpriyatie = kavaz;
IPredpiyatie holodilnikovPredpriyatie = holodilnikovZavod;
IPredpiyatie chainikovPredpriyatie = chainikovZavod;

kavazPredpriyatie.Realization();
holodilnikovPredpriyatie.Realization();
chainikovPredpriyatie.Realization();

static void Zapusk(IPredpiyatie ipred)
{
    ipred.Realization();
}


Console.ReadLine();

