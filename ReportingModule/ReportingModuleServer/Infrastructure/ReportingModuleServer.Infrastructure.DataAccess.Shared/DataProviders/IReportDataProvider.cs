using ReportingModuleServer.Domain;

namespace ReportingModuleServer.Infrastructure.DataAccess.Shared.DataProviders
{
    public interface IReportDataProvider
    {
        Task<IEnumerable<ReportDomainModel>> GetRentAndFeesReport();
    }
}
