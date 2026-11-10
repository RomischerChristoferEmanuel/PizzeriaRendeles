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
Console.WriteLine("Statisztika:");
int osszesen = adat.Sum(x => x.FizedentoDij());
Console.WriteLine($"Pizzéria teljes napi bevétele: {osszesen} Ft");
Rendeles leg = adat.MaxBy(x=>x.PizzakSzama);
Console.WriteLine($"Legtöbb pizzát rendelő vásárló: {leg.VevoNev} ({leg.PizzakSzama} db)");