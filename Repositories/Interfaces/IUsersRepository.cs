using Highfield.Entities;

namespace Highfield.Repositories.Interfaces
{
    /// <summary>
    /// Users repository contract
    /// </summary>
    public interface IUsersRepository
    {
        /// <summary>
        /// Gets the enumeration of all users
        /// </summary>
        /// <returns>The enumeration of all users</returns>
        Task<IEnumerable<User>?> GetAllUsersAsync();

        /// <summary>
        /// Resets the repository
        /// </summary>
        /// <returns></returns>
        Task ResetAsync();
    }
}
