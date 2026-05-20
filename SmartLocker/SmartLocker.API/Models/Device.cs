namespace SmartLocker.API.Models
{
    public class Device
    {
        public string DeviceID { get; set; }

        public string DeviceName { get; set; }

        public string Location { get; set; }

        public string DeviceStatus { get; set; }

        public DateTime? LastHeartbeat { get; set; }
    }
}