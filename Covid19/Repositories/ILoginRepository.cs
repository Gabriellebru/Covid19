using Covid19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Repositories
{
    public interface ILoginRepository
    {
        public Login GetLogin(Login login);
    }
}
