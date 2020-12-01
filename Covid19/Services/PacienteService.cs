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


        private ICategoriaRepository _repository;

    public PacienteService(IPacienteRepository repository)
    {
        _repository = repository;// new CategoriaRepository();
    }

    
        private IList<Paciente> listaPaciente = new List<Paciente>();

        public Paciente BuscarPacientePorId(int id)
        {
            return _repository.BuscarPacientePorId(id);
        }
        public IList<Paciente> BuscarPacienteCidade(string cidade)
        {
            return _repository.BuscarPacienteCidade(cidade);
        }
             
        public Paciente BuscarPacienteCPF(string cpf)
        {
            return _repository.BuscarPacienteCPF(cpf);
        }

        public void InserirPaciente(Paciente paciente)
        {
            var validator = new PacienteValidator();
            var validRes = validator.Validate(paciente);
            if (validRes.IsValid)
            {
                return _repository.InserirCategoria(paciente);
            }
              
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }
       
        public IList<Paciente> ListarTodosPacientes()
        {
            return _repository.ListarTodosPacientes();
        }
        
    }

}

