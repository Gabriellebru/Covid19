using Covid19.Context;
using Covid19.Models;
using Covid19.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private PacienteContext context;

        public PacienteRepository()
        {
            context = new PacienteContext();
        }

        private IList<Paciente> listaPaciente = new List<Paciente>();

        public Paciente BuscarPacientePorId(int id)
        {
            return context.paciente.Where(c => c.id == id).FirstOrDefault();
        }
        public IList<Paciente> BuscarPacienteCidade(string cidade)
        {
            return (IList<Paciente>)context.paciente.Where(p => p.cidade == cidade);
        }
        public Paciente BuscarPacienteCPF(string cpf)
        {
            return context.paciente.Where(c => c.cpf == cpf).FirstOrDefault();
        }

        public void InserirPaciente(Paciente paciente)
        {
            var validator = new PacienteValidator();
            var validRes = validator.Validate(paciente);
            if (validRes.IsValid)
                context.paciente.Add(paciente);
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }
        public IList<Paciente> ListarTodosPacientes()
        {
            return (IList<Paciente>)context.paciente;
        }
    }
}
