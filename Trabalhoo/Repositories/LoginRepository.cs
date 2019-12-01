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

                var sSQL = "SELECT * FROM users WHERE email = @email AND password = @password";
                var Result = _conn.ExecuteReader(sSQL, new { email, password});

                if (Result.Read())
                {

                    Login usu = new Login();
                    usu.Id = int.Parse(Result["id"].ToString());
                    usu.Username = Result["username"] as string;
                    usu.Email = Result["email"] as string;
                    usu.Password = Result["password"] as string;

                    Result.Close();
                    return usu;

                }

                Result.Close();
                return null;
            }
            else
            {

                var sSQL = "SELECT * FROM users WHERE email = '" + email +
                            "' AND password = '" + password + "'";
                var Result = _conn.ExecuteReader(sSQL);

                if (Result.Read())
                {

                    Login usu = new Login();
                    usu.Id = int.Parse(Result["id"].ToString());
                    usu.Username = Result["username"] as string;
                    usu.Email = Result["email"] as string;
                    usu.Password = Result["password"] as string;

                    Result.Close();
                    return usu;

                }

                Result.Close();
                return null;
            }

        }
    }
}
