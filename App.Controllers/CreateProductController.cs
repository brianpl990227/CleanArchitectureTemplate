using App.DTO;
using App.Presenters;
using App.UseCasePorts;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        private readonly ICreatePersonInputPort InputPort;
        private readonly ICreatePersonOutputPort OutputPort;

        public CreateProductController(ICreatePersonInputPort inputPort, ICreatePersonOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        [HttpPost]
        public async Task<PersonDTO> CreateProduct(CreatePersonDTO product)
        {
            await InputPort.Handle(product);

            return ((IPresenter<PersonDTO>)OutputPort).Content;
        }

    }
}