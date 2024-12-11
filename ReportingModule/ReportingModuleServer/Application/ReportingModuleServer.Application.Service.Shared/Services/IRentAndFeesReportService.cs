using ReportingModuleServer.Application.Dto.Outcome;

namespace ReportingModuleServer.Application.Service.Shared
{
    public interface IRentAndFeesReportService
    {
        Task<RentAndFeesReportResponse> GetReportAsync();
    }
}
