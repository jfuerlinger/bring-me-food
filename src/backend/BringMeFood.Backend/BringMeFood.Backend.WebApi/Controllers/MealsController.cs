using AutoMapper;
using BringMeFood.Backend.Core.Contracts;
using BringMeFood.Backend.Core.Model;
using BringMeFood.Backend.WebApi.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BringMeFood.Backend.WebApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MealsController : ControllerBase
  {
    private readonly ILogger<MealsController> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MealsController(
      ILogger<MealsController> logger,
      IUnitOfWork unitOfWork,
      IMapper mapper)
    {
      _logger = logger;
      _unitOfWork = unitOfWork;
      _mapper = mapper;
    }

    /// <summary>
    /// Lists all existing Meals.
    /// </summary>
    /// <returns>All existing meals.</returns>
    [HttpGet]
    public async Task<ActionResult<MealDto[]>> GetAsync()
    {
      var meals = await _unitOfWork
           .MealRepository
           .GetAllEntriesAsync();

      return _mapper.Map<Meal[], MealDto[]>(meals);
    }
  }
}
