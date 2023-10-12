namespace Hospital.People
{
    public class Doctor : Person
    {
        public override string Name { get; set; }
        public override string Occupation { get; set; }

        // Klassens unika attribut
        public bool CanWritePrescriptions { get; set; }

        // Constructor för klassen där vi tilldelar Name och om det får skriva ut recept
        // vi tilldelar automatiskt yrket till doktor och vi använder oss av boolen
        // CanWritePrescriptions senare då vi skriver ut information i WriteInformation metoden
        public Doctor(string name, bool canWritePrescriptions)
        {
            Name = name;
            Occupation = "doktor";
            CanWritePrescriptions = canWritePrescriptions;
        }

        public override void WriteInformation()
        {
            // string interpolation där vi vi skriver ut vårat Name, yrke och sedan kollar vi
            // OM
            //      CanWritePrescriptions är true
            //          Skriv ut "skriva ut läkemedel"
            // OM
            //      CanWritePrescriptions är false
            //          Skriv ut "inte skriva ut läkemedel"
            Console.WriteLine($"Mitt namn är {Name}. Jag är en {Occupation} och jag får " +
                $"{(CanWritePrescriptions ? "skriva ut läkemedel" : "inte skriva ut läkemedel")}");
        }

        // Klassens unika metod
        public void WritePrescription()
        {
            // Förklarning av metoden för att det ska vara tydligare att se vad som händer 
            // då vi kör programmet
            Console.WriteLine("Patienten vill ha sina recept utskrivna!");

            // Beroende på om vi får skriva ut recept eller inte så skriver vi ut olika saker i konsolen
            if (CanWritePrescriptions)
            {
                Console.WriteLine($"{Name} skriver ut en liten burk på 400 alvedon.");
            }
            else
            {
                Console.WriteLine($"{Name} får inte skriva ut medicin!");
            }
        }
    }
}
