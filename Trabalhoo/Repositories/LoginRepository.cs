using Dapper;
using Trabalhoo.Repositories;
using Trabalhoo.Models;

namespace Trabalhoo.Repositories
{
    public class LoginRepository : Repository<Login>
    {
        public Login GetLogin(string email, string password, bool tratarInjection)
        {
            if (tratarInjection)
            {

                var query = "SELECT * FROM users WHERE email = @email AND password = @password";
                var reader = _conn.ExecuteReader(query, new { email, password});
                var isAuthenticated = reader.Read();

                if (isAuthenticated)
                {

                    Login user = new Login();
                    user.Id = int.Parse(reader["id"].ToString());
                    user.Username = reader["username"] as string;
                    user.Email = reader["email"] as string;
                    user.Password = reader["password"] as string;

                    reader.Close();
                    return user;

                }

                reader.Close();
                return null;
            }
            else
            {

                var query = "SELECT * FROM users WHERE email = '" + email + "' AND password = '" + password + "'";
                var reader = _conn.ExecuteReader(query);
                var isAuthenticated = reader.Read();

                if (isAuthenticated)
                {

                    Login user = new Login();
                    user.Id = int.Parse(reader["id"].ToString());
                    user.Username = reader["username"] as string;
                    user.Email = reader["email"] as string;
                    user.Password = reader["password"] as string;

                    reader.Close();
                    return user;

                }

                reader.Close();
                return null;
            }

        }
    }
}
