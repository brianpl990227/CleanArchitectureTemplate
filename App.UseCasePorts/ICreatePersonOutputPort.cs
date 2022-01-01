using App.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UseCasePorts
{
    public interface ICreatePersonOutputPort
    {
        Task Handle(PersonDTO person);
    }
}
