using Highfield.Entities;

namespace Highfield.Connectors.Interfaces
{
    /// <summary>
    /// Users connector contract
    /// </summary>
    public interface IUsersConnector
    {
        /// <summary>
        /// Gets the enumeration of all users
        /// </summary>
        /// <returns>The enumeration of all users</returns>
        Task<IEnumerable<User>?> GetAllUsersAsync();
    }
}
