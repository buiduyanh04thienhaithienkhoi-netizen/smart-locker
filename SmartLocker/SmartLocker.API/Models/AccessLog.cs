namespace SmartLocker.API.Models
{
    public class AccessLog
    {
        public long LogID { get; set; }

        public string DeviceID { get; set; }

        public int? UserID { get; set; }

        public DateTime LogTime { get; set; }

        public double? FaceConfidence { get; set; }

        public string AccessStatus { get; set; }

        public string BlockchainTxHash { get; set; }
    }
}