namespace Ips.Vererbung.Allgemein
{
    public class Fahrzeug
    {
        private string fahrzeugArt;
        private string hersteller;
        private string typ;
        private string farbe;
        private int baujahr;

        public string FahrzeugArt
        {
            get
            {
                return fahrzeugArt;
            }

            set
            {
                fahrzeugArt = value;
            }
        }

        public string Hersteller
        {
            get
            {
                return hersteller;
            }

            set
            {
                hersteller = value;
            }
        }

        public string Typ
        {
            get
            {
                return typ;
            }

            set
            {
                typ = value;
            }
        }

        public string Farbe
        {
            get
            {
                return farbe;
            }

            set
            {
                farbe = value;
            }
        }

        public int Baujahr
        {
            get
            {
                return baujahr;
            }

            set
            {
                baujahr = value;
            }
        }
    }

    public class Landfahrzeug : Fahrzeug
    {
        private int spurbreite;
        private int fahrwerk;

        public int Spurbreite
        {
            get
            {
                return spurbreite;
            }

            set
            {
                spurbreite = value;
            }
        }

        public int Fahrwerk
        {
            get
            {
                return fahrwerk;
            }

            set
            {
                fahrwerk = value;
            }
        }

        public string GetProperties()
        {
            return string.Format("Das Landfahrzeug besitzt {0} Sitze und {1} Achsen", Fahrwerk, Spurbreite);
        }
    }

    public class Luftfahrzeug : Fahrzeug
    {
        private int maxFlughoehe = 0;
        private int anzahlPiloten = 0;

        public int MaxFlughoehe
        {
            get
            {
                return maxFlughoehe;
            }

            set
            {
                maxFlughoehe = value;
            }
        }

        public int AnzahlPiloten
        {
            get
            {
                return anzahlPiloten;
            }

            set
            {
                anzahlPiloten = value;
            }
        }

        public string GetProperties()
        {
            return string.Format("Das Luftfahrzeug hat eine max. Flughöhe von {0} und wird von {1} Piloten geflogen", MaxFlughoehe, AnzahlPiloten);
        }
    }

    public class Wasserfahrzeug : Fahrzeug
    {
        private int bruttoRegisterTonnen = 0;
        private double tiefgang = 0;

        public int BruttoRegisterTonnen
        {
            get
            {
                return bruttoRegisterTonnen;
            }

            set
            {
                bruttoRegisterTonnen = value;
            }
        }

        public double Tiefgang
        {
            get
            {
                return tiefgang;
            }

            set
            {
                tiefgang = value;
            }
        }

        public string GetProperties()
        {
            return string.Format("Das Wasserfahrzeug hat einen Tiefgang von {0} Metern und eine Verdrängung von {1} Bruttoregistertonnen", 
                Tiefgang, BruttoRegisterTonnen);
        }
    }
}
