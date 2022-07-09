namespace cloneIMDB
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Producer { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = String.Empty;
        public List<string> Actor { get; set; }= new List<string>();



    }
}
