using Trabalhoo.Models;

namespace Trabalhoo
{
    public class Global
    {
        public static Global Instance { get; private set; }
        public Login User { get; private set; }

        public void SetUser(Login login)
        {
            this.User = login;
        }

        public static void Init()
        {
            Global.Instance = new Global();
        }
    }
}
