namespace Country
{
    internal class Germany : ICountryProps
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string Continent { get; set; }
        

        public Germany() {
            Name = "Germany";
            Population = 83000000;
            Continent = "Eaurope";
        }



    }
}
