using App.DTO;
using App.UseCasePorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    public class CreatePersonPresenter : ICreatePersonOutputPort, IPresenter<PersonDTO>
    {
        public PersonDTO Content { get; private set; }

        public Task Handle(PersonDTO person)
        {
            Content = person;
            return Task.CompletedTask;
        }
    }
}
