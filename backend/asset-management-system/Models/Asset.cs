namespace asset_management_system.Models
{
    public class Asset
    {
        public Guid AssetId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime WarrantyEndDate { get; set; }
        public string Status { get; set; } // Available, Assigned, Maintenance, Retired

        public ICollection<AssetAssignment> Assignments { get; set; }
        public ICollection<AssetLogs> Logs { get; set; }
    }
}
