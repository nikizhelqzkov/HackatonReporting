
namespace ReportingModuleServer.Domain
{
    public class ReportDomainModel
    {
        public Guid RentItemId { get; set; }
        public Guid ProjectId { get; set; }
        public string? Project { get; set; }
        public string Building { get; set; } = default!;
        public Guid? BuildingGuid { get; set; }
        public string PropertyUnit { get; set; } = default!;
        public string ClassName { get; set; } = default!;
        public string? TenantRecipient { get; set; }
        public string? ContractName { get; set; }
        public DateOnly ChargeMonth { get; set; }
        public double? RentArea { get; set; }
        public decimal? Rent { get; set; }
        public decimal? ManagementFee { get; set; }
    }
}
