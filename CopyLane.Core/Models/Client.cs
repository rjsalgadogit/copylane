namespace CopyLane.Core.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public string IPAddress { get; set; }

        public string Port { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }
    }
}
