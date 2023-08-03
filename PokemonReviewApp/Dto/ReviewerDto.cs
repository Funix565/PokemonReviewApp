using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto
{
    public class ReviewerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // TODO: Fix for JSON cycles in `GetReviewsByReviewer`. We want to get a Reviewer and see the array of his reviews.
        //  But at the same time Review object also has reference to the Reviewer -> and here we have nesting.
        // public ICollection<ReviewDto> Reviews { get; set; }
    }
}
