using App.DTO;
using App.Entities.Interfaces;
using App.UseCasePorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UseCases.GetAllProducts
{
    public class GetAllPersonsInteractor : IGetAllPersonInputPort
    {
        private readonly IPersonRepository Repository;
        private readonly IGetAllPersonOutputPort OutputPort;

        public GetAllPersonsInteractor(IPersonRepository repository, IGetAllPersonOutputPort outputPort)
        {
            Repository = repository;
            OutputPort = outputPort;
        }
       

        public Task Handle()
        {   //Usar automapper aqui
            var persons = Repository.GetAll().Select(x => new PersonDTO 
            {
                Name = x.Name,
                Id = x.Id
            });

            OutputPort.Handle(persons);
            return Task.CompletedTask;

        }
    }
}
