using App.DTO;
using App.Entities.Interfaces;
using App.Entities.POCO;
using App.UseCasePorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UseCases.CreatePerson
{
    public class CreatePersonInteractor : ICreatePersonInputPort
    {

        private readonly IPersonRepository Repository;
        private readonly IUnitOfWork UnitOfWork;
        private readonly ICreatePersonOutputPort OutputPort;

        public CreatePersonInteractor(IPersonRepository repository, IUnitOfWork unitOfWork, ICreatePersonOutputPort outputPort) =>
            (Repository, UnitOfWork, OutputPort) = (repository, unitOfWork, outputPort);

        public async Task Handle(CreatePersonDTO person)
        {
            //Usar Automapper
            Person NewPerson = new Person
            {
                Name = person.Name
            };

            Repository.CreatePerson(NewPerson);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(new PersonDTO 
            { 
                Id = NewPerson.Id,
                Name = NewPerson.Name
            });


        }
    }
}
