using System.ComponentModel.DataAnnotations;

namespace CoderNextDoor.Data
{
    public class Images
    {
        [Key]
        public int ImageId { get; set; }

        public int ImageName { get; set; }
        public Post Posts { get; set; }
        public Tag Tags { get; set; }
        public Category Category { get; set; }
    }
}