using App.DTO;
using App.UseCasePorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    public class GetAllPersonsPresenter : IGetAllPersonOutputPort, IPresenter<IEnumerable<PersonDTO>>
    {
        public IEnumerable<PersonDTO> Content { get; private set;}

        public Task Handle(IEnumerable<PersonDTO> persons)
        {
            Content = persons;
            return Task.CompletedTask;
        }
    }
}
