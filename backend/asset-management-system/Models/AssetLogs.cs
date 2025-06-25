namespace asset_management_system.Models
{
    public class AssetLogs
    {
        public Guid LogId { get; set; }
        public Guid AssetId { get; set; }
        public string Description { get; set; }
        public string LoggedBy { get; set; }
        public DateTime LogDate { get; set; }

        public Asset Asset { get; set; }
    }
}
