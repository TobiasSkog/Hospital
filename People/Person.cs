namespace Hospital.People
{
    public abstract class Person
    {

        // Attributer
        public abstract string Name { get; set; }
        public abstract string Occupation { get; set; }

        // Metoder
        public abstract void WriteInformation();

    }
}
