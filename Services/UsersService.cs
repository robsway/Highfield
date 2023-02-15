using Highfield.Dtos;
using Highfield.Repositories.Interfaces;
using Highfield.Services.Interfaces;

namespace Highfield.Services
{
    /// <summary>
    /// Implementation of <see cref="IUsersService"/>
    /// </summary>
    public class UsersService : IUsersService
    {
        private IUsersRepository usersRepository;

        public UsersService(IUsersRepository usersRepository) => this.usersRepository = usersRepository;

        /// <inheritdoc/>
        public async Task<IEnumerable<UserAgedByTwentyYears>> GetAllUsersAgedByTwentyYearsAsync()
        {
            var users = await this.usersRepository.GetAllUsersAsync();

            return users?.Select(user => new UserAgedByTwentyYears
            (
                user.Id,
                user.Dob
            )) ?? Enumerable.Empty<UserAgedByTwentyYears>();
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<FavouriteUserColours>> GetFavouriteUserColoursAsync()
        {
            var allUsers = await this.usersRepository.GetAllUsersAsync();

            var favouriteUserColours = from user in allUsers
                                       group user by user.FavouriteColour into colourGroup
                                       orderby colourGroup.Count() descending, colourGroup.Key
                                       select new FavouriteUserColours(Colour: colourGroup.Key, NumberOfUsers: colourGroup.Count());

            return favouriteUserColours;
        }
    }
}
