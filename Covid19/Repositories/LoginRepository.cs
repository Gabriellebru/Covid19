using Covid19.Context;
using Covid19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        Models.Login ILoginRepository.GetLogin(Models.Login login)
        {
            throw new NotImplementedException();
        }

        public class Login : ILoginRepository
        {
            public Models.Login GetLogin(Models.Login login)
            {
                if (login.usuario == "Gabrielle" && login.senha == "123")
                {
                    login.id = 1;
                    login.role = "administrador";
                    return login;
                }
                return null;
            }

        }
    }
}
