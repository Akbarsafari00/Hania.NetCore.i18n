using System.Threading.Tasks;
using Hania.NetCore.i18n.Abstracts;
using Hania.NetCore.i18n.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Hania.NetCore.i18n.Sample.Controllers
{
    [ApiController]
    [Route("")]
    public class ApiController : ControllerBase
    {
        private readonly IHaniaLocalizer _localizer;

        public ApiController(IHaniaLocalizer localizer)
        {
            _localizer = localizer;
        }

        public Task<string> Get()
        {
            return _localizer.Localize(HttpContext.GetAcceptedLanguage(),"User","hi");
        }
    }
}