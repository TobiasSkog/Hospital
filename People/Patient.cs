namespace Hospital.People
{
    public class Patient : Person
    {
        public override string Name { get; set; }
        public override string Occupation { get; set; }

        // Klassens unika attribut
        public string Diagnosis { get; set; }
        public bool HavePrescription { get; set; }
        public string? Prescriptions { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }


        // Constructor för klassen där vi tilldelar Name, Occupation, Diagnosis och CheckIn
        // vi tilldelar automatiskt HavePrescription till false i denna constructor då vi inte
        // får en input på Prescriptions
        public Patient(string name, string occupation, string diagnosis, DateTime checkIn)
        {
            Name = name;
            Occupation = occupation;
            Diagnosis = diagnosis;
            HavePrescription = false;
            CheckIn = checkIn;
            // Baserar värdet på 2 dagar EFTER vi checkade in
            CheckOut = CheckIn.AddDays(2);
        }

        // Constructor för klassen där vi tilldelar Name, Occupation, Diagnosis och CheckIn, Prescriptions
        // vi tilldelar automatiskt HavePrescription till true i denna constructor då vi får en input på
        // prescriptions i denna versionen
        public Patient(string name, string occupation, string diagnosis, DateTime checkIn, string prescriptions)
        {
            Name = name;
            Occupation = occupation;
            Diagnosis = diagnosis;
            HavePrescription = true;
            Prescriptions = prescriptions;
            CheckIn = checkIn;
            // Baserar värdet på 7 dagar EFTER vi checkade in
            CheckOut = CheckIn.AddDays(7);
        }
        public override void WriteInformation()
        {
            // OM 
            //      HavePrescription = true
            if (HavePrescription)
            {
                // Notera! Console.Write  Vi skriver på en rad, vi skapar inte en ny rad för
                // vi vill fortsätta att lägga till in och ut checkning i slutet av texten
                // Detta innebär också att vi måste enra avsluta texten här med ´, ´ eller på börja
                // vår text EFTER if else blocken med ', '
                Console.Write($"Patient: {Name}, Diagnosis: {Diagnosis}, Recept: {Prescriptions}, ");
            }
            // OM 
            //      HavePrescription = false
            else
            {
                // Notera! Console.Write  Vi skriver på en rad, vi skapar inte en ny rad för
                // vi vill fortsätta att lägga till in och ut checkning i slutet av texten
                // Detta innebär också att vi måste enra avsluta texten här med ´, ´ eller på börja
                // vår text EFTER if else blocken med ', '
                Console.Write($"Patient: {Name}, Diagnosis: {Diagnosis}, ");
            }

            // Notera! Console.Write  Vi skriver på en rad, vi skapar inte en ny rad för
            // vi vill fortsätta att lägga till in och ut checkning i slutet av texten
            Console.Write($"Incheckning: {CheckIn:D}, Utcheckning: {CheckOut:D}.");
        }

        // Klassens unika metod
        public void PressTheRedButton()
        {
            Console.WriteLine("Patienten har upptäckt en röd knapp, fäst på en liten dosa som hänger så fint på väggen... Undrar vad som händer om man trycker på den");
            Console.WriteLine($"{Name} har tryckt på den röda knappen och läkaren kommer springandes in till rummet");
        }
    }
}
