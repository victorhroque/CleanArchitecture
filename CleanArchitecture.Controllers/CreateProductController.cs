using CleanArchitecture.DTOs;
using CleanArchitecture.Presenters;
using CleanArchitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        private readonly ICreateProductInputPort _createProductInputPort;
        private readonly ICreateProductOuputPort _createProductOuputPort;

        public CreateProductController(ICreateProductInputPort createProductInputPort,
            ICreateProductOuputPort createProductOuputPort)
        {
            _createProductInputPort = createProductInputPort;
            _createProductOuputPort = createProductOuputPort;
        }

        [HttpPost]
        public async Task<ProductDTO> Post(CreateProductDTO productDTO)
        {
            await _createProductInputPort.Handle(productDTO);
            return ((IPresenter<ProductDTO>)_createProductOuputPort).Content;
        }
    }
}
