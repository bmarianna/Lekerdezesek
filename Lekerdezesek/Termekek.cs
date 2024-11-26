using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekerdezesek
{
    internal class Termekek
    {
        List<Termek> termekek;
        public Termekek()
        {
            TermekekGeneralasa();
        }
        private void TermekekGeneralasa()
        {
             termekek = new List<Termek>
        {
            new Termek(1, "Laptop", 120000, "Elektronika"),
            new Termek(2, "Okostelefon", 80000, "Elektronika"),
            new Termek(3, "Tablet", 60000, "Elektronika"),
            new Termek(4, "TV", 150000, "Elektronika"),
            new Termek(5, "Hűtőszekrény", 180000, "Háztartás"),
            new Termek(6, "Mosógép", 140000, "Háztartás"),
            new Termek(7, "Vasaló", 10000, "Háztartás"),
            new Termek(8, "Kenyérpirító", 7000, "Háztartás"),
            new Termek(9, "Szék", 20000, "Bútor"),
            new Termek(10, "Asztal", 40000, "Bútor"),
            new Termek(11, "Kanapé", 120000, "Bútor"),
            new Termek(12, "Szekrény", 100000, "Bútor"),
            new Termek(13, "Függöny", 8000, "Lakberendezés"),
            new Termek(14, "Lámpa", 12000, "Lakberendezés"),
            new Termek(15, "Ágy", 150000, "Bútor"),
            new Termek(16, "Toll", 500, "Irodaszer"),
            new Termek(17, "Jegyzetfüzet", 1500, "Irodaszer"),
            new Termek(18, "Monitor", 70000, "Elektronika"),
            new Termek(19, "Egér", 5000, "Elektronika"),
            new Termek(20, "Billentyűzet", 8000, "Elektronika"),
            new Termek(21, "Porzsák", 3000, "Háztartás"),
            new Termek(22, "Kávéfőző", 25000, "Háztartás"),
            new Termek(23, "Hátizsák", 15000, "Divat"),
            new Termek(24, "Cipő", 30000, "Divat"),
            new Termek(25, "Óra", 50000, "Divat")
        };
        }

        

    }
}
