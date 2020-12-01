using Covid19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Services
{
    public interface IPacienteService
    {
        public int IserirPaciente(Paciente Paciente);

        public Paciente BuscarPacienteCidade(string Cidade);
        public Paciente BuscarPacientePorId(int pid);
        public IList<Paciente> ListarTodosPacientes();

    }
}
