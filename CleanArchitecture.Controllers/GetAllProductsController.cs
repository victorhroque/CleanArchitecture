using CleanArchitecture.DTOs;
using CleanArchitecture.Presenters;
using CleanArchitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        private readonly IGetAllProductsInputPort _getAllProductsInputPort;
        private readonly IGetAllProductsOutputPort _getAllProductsOutputPort;

        public GetAllProductsController(IGetAllProductsInputPort getAllProductsInputPort,
            IGetAllProductsOutputPort getAllProductsOutputPort)
        {
            _getAllProductsInputPort = getAllProductsInputPort;
            _getAllProductsOutputPort = getAllProductsOutputPort;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> Get()
        {
            await _getAllProductsInputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDTO>>)_getAllProductsOutputPort).Content;
        }
    }
}
