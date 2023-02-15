using Highfield.Extensions;

namespace Highfield.Dtos
{
    public record UserAgedByTwentyYears(string UserId, DateTime Dob)
    {
        /// <remarks>This may be private data so make the property private</remarks>
        private DateTime Dob { get; init; } = Dob;

        public int OriginalAge => Dob.GetAge();

        public int AgePlusTwenty => OriginalAge + 20;
    }
}
