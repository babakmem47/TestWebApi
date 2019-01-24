using System.Collections.Generic;

namespace WebApiTest.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Gig> Gigs { get; set; }

    }
}