namespace PokemonReviewApi.Models
{
    public class Owner
    {
      

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }// 1-M (1 country per owner)
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public string LastName { get; internal set; }
        public string FirstName { get; internal set; }
    }
}
