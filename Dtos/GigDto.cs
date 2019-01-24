using System;

namespace WebApiTest.Dtos
{
    public class GigDto
    {
        public int IdOfGig { get; set; }
        public UserDto Performer { get; set; }
        public DateTime DateTimeOfGig { get; set; }
        public string Location { get; set; }
        public GenreDto GenreDto { get; set; }
        public bool BeenCanceled { get; set; }
    }
}