using Highfield.Connectors.Interfaces;
using Highfield.Entities;
using Highfield.Repositories.Interfaces;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Extensions.Caching.Memory;

namespace Highfield.Repositories
{
    /// <summary>
    /// Implementation of <see cref="IUsersRepository"/>
    /// </summary>
    public class UsersRepository : IUsersRepository
    {
        private const string USERS_CACHE_KEY = "users";

        private readonly IMemoryCache memoryCache;
        private readonly IUsersConnector usersConnector;

        public UsersRepository(
            IUsersConnector usersConnector,
            IMemoryCache memoryCache)
        {
            this.usersConnector = usersConnector;
            this.memoryCache = memoryCache;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<User>?> GetAllUsersAsync()
        {
            if (this.memoryCache.TryGetValue(
                USERS_CACHE_KEY,
                out IEnumerable<User>? users))
            {
                return users;
            }

            users = await this.usersConnector.GetAllUsersAsync() ?? Enumerable.Empty<User>();

            if (users.Any())
            {
                this.memoryCache.Set(
                    USERS_CACHE_KEY,
                    users,
                    TimeSpan.FromMinutes(10));
            }

            return users;
        }

        /// <inheritdoc/>
        public Task ResetAsync()
        {
            this.memoryCache.Remove(USERS_CACHE_KEY);

            return Task.CompletedTask;
        }
    }
}
