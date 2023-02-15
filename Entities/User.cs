using System.ComponentModel.DataAnnotations;

namespace Highfield.Entities
{
    public record User(string Id, string FirstName, string LastName, [EmailAddress] string Email, DateTime Dob, string FavouriteColour);
}
