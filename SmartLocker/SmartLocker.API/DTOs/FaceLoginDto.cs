namespace SmartLocker.API.DTOs
{
    public class FaceLoginDto
    {
        public string DeviceID { get; set; }

        public int? UserID { get; set; }

        public double? FaceConfidence { get; set; }

        public string AccessStatus { get; set; }
    }
}