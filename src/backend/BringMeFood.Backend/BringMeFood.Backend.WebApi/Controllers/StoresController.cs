using AutoMapper;
using BringMeFood.Backend.Core.Contracts;
using BringMeFood.Backend.Core.Model;
using BringMeFood.Backend.WebApi.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BringMeFood.Backend.WebApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StoresController : ControllerBase
  {
    private readonly ILogger<StoresController> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public StoresController(
      ILogger<StoresController> logger,
      IUnitOfWork unitOfWork,
      IMapper mapper)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
      _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<StoreDto[]>> Get()
    {
      var stores = await _unitOfWork
           .StoreRepository
           .GetAllEntriesAsync();

      return _mapper.Map<Store[], StoreDto[]>(stores);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<StoreDto[]>> Post(StoreDto store)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest("Invalid data.");
      }

      Store storeToBeCreated = new Store()
      {
        Name = store.Name
      };

      await _unitOfWork.StoreRepository.AddAsync(storeToBeCreated);
      await _unitOfWork.SaveAsync();

      return CreatedAtAction(nameof(Post), new { id = storeToBeCreated.Id }, _mapper.Map<Store, StoreDto>(storeToBeCreated));
    }
  }
}
