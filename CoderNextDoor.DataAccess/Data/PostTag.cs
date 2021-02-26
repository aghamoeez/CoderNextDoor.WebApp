using CoderNextDoor.DataAccess.DataHelpers;

namespace CoderNextDoor.Data
{
    public class PostTag : Entity
    {
        public int TagId { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public virtual Tag Tag { get; set; }
    }
}