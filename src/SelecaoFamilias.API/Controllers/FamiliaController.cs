using Microsoft.AspNetCore.Mvc;
using SelecaoFamilias.Application.Interfaces;
using SelecaoFamilias.Application.ViewModels;
using SelecaoFamilias.Domain.Interfaces.Repository;

namespace SelecaoFamilias.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FamiliaController : ControllerBase
    {
        private readonly IFamiliaAptaRepository _familiaAptaRepository;
        private readonly IFamiliaAppService _familiaAppService;

        public FamiliaController(
            IFamiliaAptaRepository familiaAptaRepository,
            IFamiliaAppService familiaAppService)
        {
            _familiaAptaRepository = familiaAptaRepository;
            _familiaAppService = familiaAppService;
        }

        [HttpPost]
        public IActionResult Cadastrar(FamiliaViewModel familiaViewModel)
        {
             var resultViewModel =_familiaAppService.CadastrarFamilia(familiaViewModel);

            if (!resultViewModel.Sucesso) return BadRequest(resultViewModel.Mensagens);

            return Ok();
        }

        [HttpGet]
        public IActionResult ObterFamiliasAptasAGanharCasaPopular()
        {
            var resultados =  _familiaAptaRepository.ObterFamiliasAptasOrdenadasPorPontuacao();

            return Ok(resultados);
        }
    }
}
