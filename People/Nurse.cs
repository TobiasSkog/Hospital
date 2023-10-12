namespace Hospital.People
{
    public class Nurse : Person
    {
        public override string Name { get; set; }
        public override string Occupation { get; set; }

        // Klassens unika attribut
        public string Shift { get; set; }

        // Constructor för klassen där vi tilldelar Name och Shift
        // vi tilldelar automatiskt yrket till sjuksköterska
        public Nurse(string name, string shift)
        {
            Name = name;
            Occupation = "sjuksköterska";
            Shift = shift;
        }

        public override void WriteInformation()
        {
            Console.WriteLine($"Mitt namn är {Name}. Jag är en {Occupation} " +
                $"och jag jobbar {Shift}");
        }

        // Klassens unika metod
        public void TakeBloodTest()
        {
            // Förklarning av metoden för att det ska vara tydligare att se vad som händer 
            // då vi kör programmet
            Console.WriteLine("Patienten behöver ett nytt blodprov!");
            Console.WriteLine($"{Name} hämtar dunken, nu är det dags för ett blodprov!");
        }
    }
}
