using NubancoApp.Models;
using NubancoApp.Repositories;

namespace NubancoApp.Services
{
    public class LoginService : Service<Login>
    {
        private LoginRepository _repository { get; set; }

        public LoginService()
        {
            _repository = new LoginRepository();
            this.SetRepository(_repository);
        }

        public Login GetLogin(string email, string password, bool tratarInjection)
        {
            return this._repository.GetLogin(email, password, tratarInjection);
        }
    }
}
