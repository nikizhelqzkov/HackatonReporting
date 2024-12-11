using ReportingModuleServer.Application.Dto;
using ReportingModuleServer.Application.Dto.Outcome;
using ReportingModuleServer.Application.Service.Shared;
using ReportingModuleServer.Infrastructure.DataAccess.Shared.DataProviders;

public class RentAndFeesReportService(IReportDataProvider repository) : IRentAndFeesReportService
{
    public async Task<RentAndFeesReportResponse> GetReportAsync()
    {
        var rentAndFeesDomainModelList = await repository.GetRentAndFeesReport();

        var rentAndFeesDTOList =  rentAndFeesDomainModelList.Select(result => new RentAndFeesReportDTO
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

        var rentAndFeesReportResponse = new RentAndFeesReportResponse
        {
            RentAndFeesReportDTO = rentAndFeesDTOList.ToList(),
        };

        return rentAndFeesReportResponse;
    }
}
