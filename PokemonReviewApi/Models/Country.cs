namespace PokemonReviewApi.Models
{
    public class Country
    {
        public int Id { get; set; }
       public string Name { get; set; }
        public ICollection<Owner> Owners { get; set; } // collection because rs is 1-M
    }
}
