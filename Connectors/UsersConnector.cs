using Highfield.Connectors.Interfaces;
using Highfield.Entities;

namespace Highfield.Connectors
{
    /// <summary>
    /// Implementaton of <see cref="IUsersConnector"/>
    /// </summary>
    public class UsersConnector : IUsersConnector
    {
        IHttpClientFactory httpClientFactory;

        public UsersConnector(IHttpClientFactory httpClientFactory) => this.httpClientFactory = httpClientFactory;

        /// <inheritdoc/>
        public async Task<IEnumerable<User>?> GetAllUsersAsync()
        {
            var userClient = this.httpClientFactory.CreateClient(nameof(User));

            var users = await userClient.GetFromJsonAsync<User[]>("api/test");

            return users;
        }
    }
}
