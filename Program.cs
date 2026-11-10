using PizzeriaRendeles;

List<Rendeles>adat=new List<Rendeles>();
Console.WriteLine("Napi rendelések:");
foreach (string sor in File.ReadAllLines("rendelesek.txt"))
{
    adat.Add(new Rendeles(sor));
}
foreach(Rendeles aktualis in adat)
{
    Console.WriteLine(aktualis);
}