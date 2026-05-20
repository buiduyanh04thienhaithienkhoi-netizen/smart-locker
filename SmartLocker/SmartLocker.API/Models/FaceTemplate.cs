namespace SmartLocker.API.Models
{
    public class FaceTemplate
    {
        public int FaceID { get; set; }

        public int UserID { get; set; }

        public string ImagePath { get; set; }

        public string FaceVector { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}