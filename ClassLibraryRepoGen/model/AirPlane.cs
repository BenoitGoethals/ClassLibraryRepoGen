namespace ClassLibraryRepoGen.model
{
    public class AirPlane:Item
    {
        public AirPlane(int id, string name, int age, int span, int countEngines) : base(id, name, age)
        {
            Span = span;
            CountEngines = countEngines;
        }

        public int Span { get; set; }
        public int CountEngines { get; set; }



    }
}