using ApiPruebaAgentes.Application.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ApiPruebaAgentes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IGetMediaAppService _valuesAppService;
        private readonly IGetMedianaAppService _getMedianaAppService;
        private readonly IGetStairAppService _getStairAppService;
        private readonly IGetStairInvAppService _getStairInvAppService;
        private readonly IGetRomboAppService _getRomboAppService;

        public ValuesController(IGetMediaAppService valuesAppService, IGetMedianaAppService getMedianaAppService, IGetStairAppService getStairAppService,
            IGetStairInvAppService getStairInvAppService, IGetRomboAppService getRomboAppService)
        {
            this._valuesAppService = valuesAppService;
            this._getMedianaAppService = getMedianaAppService;
            this._getStairAppService = getStairAppService;
            this._getStairInvAppService = getStairInvAppService;
            this._getRomboAppService = getRomboAppService;
        }

        [HttpPost]
        [Route(nameof(GetMedia))]
        public async Task<ActionResult<int>> GetMedia([FromBody] List<int> n)
        {
            int response = await _valuesAppService.GetMedia(n);

            return Ok(response);
        }

        [HttpPost]
        [Route(nameof(GetMediana))]
        public async Task<ActionResult<int>> GetMediana([FromBody] List<int> n)
        {
            int response = await _getMedianaAppService.GetMediana(n);

            return Ok(response);
        }

        [HttpGet]
        [Route(nameof(GetStair))]
        public async Task<ActionResult> GetStair(int n)
        {
            StringBuilder sb = await _getStairAppService.GetStair(n);

            return Ok(sb.ToString());
        }

        [HttpGet]
        [Route(nameof(GetStairInv))]
        public async Task<ActionResult> GetStairInv(int n)
        {
            StringBuilder sb = await _getStairInvAppService.GetStairInv(n);

            return Ok(sb.ToString());
        }

        [HttpGet]
        [Route(nameof(GetRombo))]
        public async Task<ActionResult> GetRombo(int n)
        {
            StringBuilder sb = await _getRomboAppService.GetRombo(n);

            return Ok(sb.ToString());
        }
    }
}
