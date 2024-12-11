using ReportingModuleServer.Domain;
using ReportingModuleServer.Infrastructure.DataAccess.Shared.DataProviders;
using ReportingModuleServer.Infrastructure.DataAccess.Sql.Context;

namespace ReportingModuleServer.Infrastructure.DataAccess.Sql.DataProviders
{
    public class ReportDataProvider(ReportsContext context) : IReportDataProvider
    {
        public async Task<IEnumerable<ReportDomainModel>> GetRentAndFeesReport()
        {
            var rentAndFeesEntityList = await context.Procedures.uspGetContractRentAndFeesReportSourceAsync(
                Projects: "207244C4-E701-490A-B5BE-9287BD7F07B8",
                StartPeriod: new DateOnly(2024, 1, 1),
                Contracts: "d0bfc1e2-c3a1-ef11-bfe8-005056a51b07,33aadf8e-93a2-ef11-bfe8-005056a51b07,a3cea178-7ca6-ef11-bfe8-005056a51b07,87207643-7da6-ef11-bfe8-005056a51b07,560074d8-3fa7-ef11-bfe8-005056a51b07,a0ddb345-f6b6-ef11-bfea-005056a51b07",
                EndPeriod: new DateOnly(2026, 12, 1),
                Classes: "10",
                Buildings: "831d311a-a2ff-427d-b14c-b47e9a8c4f8f,fb0d91bc-c150-4e80-82b5-4b2b2c10b668",
                ToCurrency: 1,
                fromBGN: "1",
                fromEUR: "1",
                fromUSD: "1",
                IsExchangeRatesCorrect: true,
                LocaleId: 1,
                UserName: "W3KNBG\\Valentin Popov"
            );

            var reportDomainModelList = rentAndFeesEntityList.Select(result => new ReportDomainModel
            {
                RentItemId = result.RentItemId,
                ProjectId = result.ProjectId,
                Project = result.Project,
                Building = result.Building,
                BuildingGuid = result.BuildingGuid,
                PropertyUnit = result.PropertyUnit,
                ClassName = result.ClassName,
                TenantRecipient = result.TenantRecipient,
                ContractName = result.ContractName,
                ChargeMonth = result.ChargeMonth,
                RentArea = result.RentArea,
                Rent = result.Rent,
                ManagementFee = result.ManagementFee
            });

            return reportDomainModelList;
        }
    }
}
