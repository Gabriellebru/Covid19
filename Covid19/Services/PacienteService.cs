using Covid19.Models;
using Covid19.Repositories;
using Covid19.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Services
{
    public class PacienteService : IPacienteService {
        private readonly IPacienteRepository _repository;
        public PacienteService(
             IPacienteRepository repository
         )
        {
            _repository = repository;
        }


        private IList<Paciente> listaPaciente = new List<Paciente>();

        public Paciente BuscarPacientePorId(int id)
        {
            return _repository.buscaPorId(id);
        }
               
      
        public void InserirPaciente(Paciente paciente)
        {

            return _repository.novoPaciente(paciente);
        }
       
        public IList<Paciente> ListarTodosPacientes()
        {
            return _repository.buscaTodosPacientes();
        }
        
    }

}

