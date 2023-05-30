using System;
using System.Linq;

namespace rendelesek
{
    internal class Program
    {
        //1.
        static List<Rendeles> rendelesek = File.ReadAllLines("rendeles.csv").Where(x => x[0] == 'T').Select(x => new Rendeles(int.Parse(x.Split(';')[1]), x.Split(';')[2], int.Parse(x.Split(';')[3]))).ToList();
        static List<Rendelo> rendelok = File.ReadAllLines("rendeles.csv").Where(x => x[0] == 'M').Select(x => new Rendelo(x.Split(';')[1], int.Parse(x.Split(';')[2]), x.Split(';')[3])).ToList();
        static List<Raktar> raktar = File.ReadAllLines("raktar.csv").Select(x => new Raktar(x.Split(';')[0], int.Parse(x.Split(';')[2]), int.Parse(x.Split(';')[3]))).ToList();
        static void Main(string[] args)
        {

            //2.

            foreach (var rendelesSzam in rendelok)
            {
                bool rendelheto = true;
                var rendeles = rendelesek.Where(x => x.ID == rendelesSzam.ID).ToList();

                foreach (var tetel in rendeles)
                {
                    rendelheto = raktar.Where(x => x.Termek == tetel.Termek).Any(x => x.Mennyiseg >= tetel.Mennyiseg);
                    if (!rendelheto) break;
                }
                if (!rendelheto) 
                {
                    rendelesSzam.Teljesitheto = false;
                    continue;
                };
                
                foreach (var tetel in rendeles)
                {
                    foreach (var item in raktar)
                    {
                        if (item.Termek == tetel.Termek)
                        {
                            item.Mennyiseg -= tetel.Mennyiseg;
                            break;
                        }
                    }
                }
            }

            //3.
            List<string> f = new List<string>();
            rendelok.ToList().ForEach(x => f.Add(x.Email + ";" + (x.Teljesitheto) ? "A rendelését két napon belül szállítjuk. A rendelés értéke: x Ft." : "A rendelése függő állapotba került. Hamarosan értesítjük a szállítás időpontjáról"));
            File.WriteAllLines("F.txt", f, encoding: System.Text.Encoding.UTF8);

            //4.
            // Elnézést kérek tanárúr, de több óra kutakodás után sem tudtam rájönni a megoldásra
        }
    }
}