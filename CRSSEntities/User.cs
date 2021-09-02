using System.ComponentModel.DataAnnotations;

namespace CRSSEntities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Identification { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }
    }
}
