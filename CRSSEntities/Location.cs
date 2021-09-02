using System.ComponentModel.DataAnnotations;

namespace CRSSEntities
{
    public class Location
    {
        public int LocationId { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }
    }
}
