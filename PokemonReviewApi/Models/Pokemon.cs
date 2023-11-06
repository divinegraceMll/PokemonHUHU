namespace PokemonReviewApi.Models // Model is a databse table
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; } // collection because rs is 1-M
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
