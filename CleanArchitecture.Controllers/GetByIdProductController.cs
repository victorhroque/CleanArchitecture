using CleanArchitecture.DTOs;
using CleanArchitecture.Presenters;
using CleanArchitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetByIdProductController
    {
        private readonly IGetByIdProductInputPort _inputPort;
        private readonly IGetByIdProductOutputPort _outputPort;

        public GetByIdProductController(IGetByIdProductInputPort inputPort, IGetByIdProductOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpGet]
        public async Task<GetByIdProductDTO> Get(int id)
        {
            await _inputPort.Handle(id);
            return ((IPresenter<GetByIdProductDTO>)_outputPort).Content;
        }
    }
}
