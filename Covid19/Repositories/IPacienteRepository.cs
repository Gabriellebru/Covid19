using Covid19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Repositories
{
    interface IPacienteRepository
    {
        public Paciente buscaPorId(int id);
        public IList<Paciente> buscaTodosPacientes();
        public void novoPaciente(Paciente paciente);
    }
}
