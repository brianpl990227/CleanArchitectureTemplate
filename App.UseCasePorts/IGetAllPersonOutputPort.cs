using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UseCasePorts
{
    public interface IGetAllPersonOutputPort
    {
        Task Handle(IEnumerable<PersonDTO> persons);
    }
}
