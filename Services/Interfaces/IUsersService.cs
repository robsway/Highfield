using Highfield.Dtos;

namespace Highfield.Services.Interfaces
{
    public interface IUsersService
    {
        /// <summary>
        /// Gets all users aged by twenty years
        /// </summary>
        /// <returns>The enumeration of all users aged by twenty years</returns>
        Task<IEnumerable<UserAgedByTwentyYears>> GetAllUsersAgedByTwentyYearsAsync();

        /// <summary>
        /// Gets users favourite colours in order of popularity and then colour name
        /// </summary>
        /// <returns>The enumeration of ordered favourite user colours</returns>
        Task<IEnumerable<FavouriteUserColours>> GetFavouriteUserColoursAsync();
    }
}
