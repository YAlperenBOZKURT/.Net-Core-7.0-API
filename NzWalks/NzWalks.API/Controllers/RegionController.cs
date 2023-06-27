using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NzWalks.API.Models.Domain;
using NzWalks.API.Models.DTO;
using NzWalks.API.RepositoryPattern.Interfaces;
using System.Text.Json;

namespace NzWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;
        private readonly ILogger<RegionController> logger;

        public RegionController(IRegionRepository regionRepository, IMapper mapper, ILogger<RegionController> logger)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
            this.logger = logger;
        }
        // GET ALL REGIONS
        // GET : https ://localhost:portnumber/api/regions
        [HttpGet]
        [Authorize(Roles = "Reader,Writer")]
        public async Task<IActionResult> GetAll()
        {
            logger.LogInformation("GetAllRegionsAction Method was invoked!");
            var regionsDomain = await regionRepository.GetAllAsync();
          
            // Map Domain Models to DTOs
            return Ok(mapper.Map<List<RegionDto>>(regionsDomain));
        }


        // Get Region by ID
        // Get: /api/regions/id
        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Reader,Writer")]
        public async Task<IActionResult> GetByID([FromRoute] Guid id)
        {
            var regionsDomain = await regionRepository.GetByIDAsync(id);

            if (regionsDomain == null)
            {
                return NotFound();
            }
            //Map Domain model to DTO
            return Ok(mapper.Map<RegionDto>(regionsDomain));
        }

        // Put Region by ID
        // Put: /api/regions/id
        [HttpPut]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdateRegionRquestDto updateRegionRquestDto)
        {

            //map dto to domain modei
            var regionsDomain = mapper.Map<Region>(updateRegionRquestDto);

            regionsDomain = await regionRepository.UpdateAsync(id, regionsDomain);

            if (regionsDomain == null)
            {
                return NotFound();
            }
            //Map Domain model to DTO
            return Ok(mapper.Map<RegionDto>(regionsDomain));
        }


        // Delete  Region by ID
        // Delete : /api/regions/id
        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var regionsDomain = await regionRepository.DeleteAsync(id);

            if (regionsDomain == null)
            {
                return NotFound();
            }

            //Map Domain model to DTO
            return Ok(mapper.Map<RegionDto>(regionsDomain));
        }

        // Create Region
        // Post: /api/regions
        [HttpPost]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {

            //Map DTO to domain model
            var regionsDomain = mapper.Map<Region>(addRegionRequestDto);

            await regionRepository.CreateAsync(regionsDomain);

            //Map Domain model to DTO

            return Ok(mapper.Map<RegionDto>(regionsDomain));


        }
    }
}
