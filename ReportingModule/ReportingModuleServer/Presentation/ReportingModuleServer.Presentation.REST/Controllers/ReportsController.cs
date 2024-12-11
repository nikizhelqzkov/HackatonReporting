using Microsoft.AspNetCore.Mvc;
using ReportingModuleServer.Application.Dto.Outcome;
using ReportingModuleServer.Application.Service.Shared;

namespace ReportingModuleServer.Presentation.REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController(IRentAndFeesReportService reportService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<RentAndFeesReportResponse>> GetRentAndFeesReport()
        {
            RentAndFeesReportResponse response = await reportService.GetReportAsync();
            return Ok(response);
        }
    }
}
