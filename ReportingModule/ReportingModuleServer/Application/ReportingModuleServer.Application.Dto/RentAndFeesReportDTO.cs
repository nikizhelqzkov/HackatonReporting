
namespace ReportingModuleServer.Application.Dto
{
    public class RentAndFeesReportDTO
    {
        public Guid RentItemId { get; set; }
        public Guid ProjectId { get; set; }
        public string? Project { get; set; }
        public string Building { get; set; } = string.Empty;
        public Guid? BuildingGuid { get; set; }
        public string PropertyUnit { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string? TenantRecipient { get; set; }
        public string? ContractName { get; set; }
        public DateOnly ChargeMonth { get; set; }
        public double? RentArea { get; set; }
        public decimal? Rent { get; set; }
        public decimal? ManagementFee { get; set; }
    }
}
