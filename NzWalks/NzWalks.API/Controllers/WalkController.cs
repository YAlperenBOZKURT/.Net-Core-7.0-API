using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NzWalks.API.Models.Domain;
using NzWalks.API.Models.DTO;
using NzWalks.API.RepositoryPattern.Interfaces;

namespace NzWalks.API.Controllers
{
    //api/walks 
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;
        private readonly ILogger logger;

        public WalksController(IMapper mapper, IWalkRepository walkRepository, ILogger<WalksController> logger)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
            this.logger = logger;
        }
        // Create Walk
        // Post: /api/walks
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDto addWalkRequestDto)
        {

            //Map DTO to domain model
            var walkDomainModel = mapper.Map<Walk>(addWalkRequestDto);

            await walkRepository.CreateAsync(walkDomainModel);

            //Map Domain model to DTO

            return Ok(mapper.Map<WalkDto>(walkDomainModel));


        }

        // Get Walk
        // Get: /api/walks?filterOn=Name&filterQuery=Track&sortBy=Name&isAcending=true&pageNumber=1&pageSize=10
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy, [FromQuery] bool? isAscending, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
        {
            logger.LogInformation("GetAllRegionsAction Method was invoked!");
            var walkDomainModel = await walkRepository.GetAllAsync(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber, pageSize);
            //Map Domain model DTO
            return Ok(mapper.Map<List<WalkDto>>(walkDomainModel));

        }

        // Get Walk by ID
        // Get: /api/walks/id
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetByID([FromRoute] Guid id)
        {
            var walkDomainModel = await walkRepository.GetByIDAsync(id);

            if (walkDomainModel == null)
            {
                return NotFound();
            }
            //Map Domain model to DTO
            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }

        // Put Walk by ID
        // Put: /api/walks/id
        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdateWalkRuqestDto updateWalkRuqestDto)
        {

            //map dto to domain modei
            var walkDomainModel = mapper.Map<Walk>(updateWalkRuqestDto);

            walkDomainModel = await walkRepository.UpdateAsync(id, walkDomainModel);

            if (walkDomainModel == null)
            {
                return NotFound();
            }

            //Map Domain model to DTO
            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }


        // Delete  Walk by ID
        // Delete : /api/walks/id
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var walkDomainModel = await walkRepository.DeleteAsync(id);

            if (walkDomainModel == null)
            {
                return NotFound();
            }

            //Map Domain model to DTO
            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }

    }
}
