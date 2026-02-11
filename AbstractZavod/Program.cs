using AbstractZavod;

ChainikovZavod chainikovZavod = new ChainikovZavod();
HolodilnikovZavod holodilnikovZavod = new HolodilnikovZavod();
Kavaz kavaz = new Kavaz();
Fabrica fabrica = new Fabrica();

IPredpiyatie zavod2 = new Fabrica();


kavaz.Proizvodit();
holodilnikovZavod.Proizvodit();
chainikovZavod.Proizvodit();
zavod2.Realization();

IPredpiyatie kavazPredpriyatie = kavaz;
IPredpiyatie holodilnikovPredpriyatie = holodilnikovZavod;
IPredpiyatie chainikovPredpriyatie = chainikovZavod;



kavazPredpriyatie.Realization();
holodilnikovPredpriyatie.Realization();
chainikovPredpriyatie.Realization();




Console.ReadLine();

