using APIDesafioBlip.Models;
using APIDesafioBlip.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIDesafioBlip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoryController : ControllerBase
    {
        private readonly IRepositoryRepository _repositoryRepository;
        public RepositoryController(IRepositoryRepository repositoryRepository)
        {
            _repositoryRepository = repositoryRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Repository>>> FindRepository()
        {
            var ListResponse = await _repositoryRepository.FindRepository();
            if (ListResponse == null)
            {
                return NotFound();
            }
            return Ok(ListResponse);
        }

    }
}
