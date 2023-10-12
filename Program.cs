using Hospital.People;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar en lista av typen 'Person' som heter personnel. Det är en NY lista
            // och vi tilldelar direkt värden i den med hjälp av måsvingar.
            // Istället för att göra den lånsamma vägen med att skapa en lista sen ett nytt objekt sedan lägga till objektet i listan
            //List<Person> personnel = new List<Person>();
            //Doctor aldor = new Doctor("Aldor", true);
            //personnel.Add(aldor);
            // Så skapar vi Listan och instansierar den med värden direkt!
            // Eftersom vi lägger in nya klasser direkt, behöver vi inte skapa en variabel med ett variabel Name
            // utan vi kan direkt lägga in en ny isntans av klassen
            List<Person> personnel = new List<Person>()
            {
                new Doctor("Aldor", true),
                new Doctor("Reidar", false),
                new Nurse("Tobias", "natt skift"),
                new Patient("Jonna", "student", "ont i magen", new DateTime(1942, 05, 12, 04, 24, 10), "Amfetamin"),
                new Patient("Zia", "brandman", "inhalerat rök och 3e gradens brännskador", DateTime.Now),
                new Patient("Tobias", "programmerare", "mänskoskygg och inte sett solljus på på månader", new DateTime(2020, 01, 10), "antidepressiva, ångestdämpande, lugnande"),
                new Nurse("Viktoria", "dag skift"),
            };

            // Om vi vill ha en räknare för varje patient kan vi göra en ny int counter här
            // som vi i foreach loopen sedan inkrementerar med counter ++ om det är en patient blocket

            // Vanliga foreach loop där vi loopar igenom vår lista personnel som vi skapade tidigare
            foreach (var person in personnel)
            {
                // Alla subklasser av Person har en metod som heter WriteInformation.
                // Vi kallar den på alla klasser i listan
                person.WriteInformation();

                // Vi kollar om just denna personen i listan är av klassen Doctor
                if (person.GetType() == typeof(Doctor))
                {
                    // skapar en referens till personen men vi unboxar den som en Doctor
                    // så vi har tillgång till Doctor klassens specifika metoder
                    var doctor = (Doctor)person;
                    doctor.WritePrescription();
                }
                // Vi kollar om just denna personen i listan är av klassen Nurse
                // detta är ett lättare och snabbare sätt att skriva ovanstående kontroll
                // som är både tydlig, lätt att förstå och snabbare att skriva!
                else if (person is Nurse)
                {
                    // skapar en referens till personen men vi unboxar den som en Nurse
                    // så vi har tillgång till Nurse klassens specifika metoder
                    var nurse = (Nurse)person;
                    nurse.TakeBloodTest();
                }
                // Då vi inte har fler typer av klasser i våran lista 
                // och det inte är en Doctor eller Nurse så kan det 
                // bara vara en patient
                else
                {
                    // skapar en referens till personen men vi unboxar den som en Patient
                    // så vi har tillgång till Patient klassens specifika metoder
                    var patient = (Patient)person;
                    patient.PressTheRedButton();
                }

                // Skriver en tom rad för att få en snyggare utskrift i consolen
                Console.WriteLine();
            }
        }
    }

}