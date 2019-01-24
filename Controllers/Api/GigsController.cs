using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers.Api
{
    [Authorize]
    public class GigsController : ApiController
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult CancelAGig(int id)
        {
            var currentUserId = User.Identity.GetUserId();
            var gig = _context.Gigs.Single(g => g.Id == id && g.ArtistId == currentUserId);

            if (gig.IsCanceled)
            {
                return NotFound();
            }

            gig.IsCanceled = true;
            _context.SaveChanges();

            //return Ok();
            return Ok("Gig with the id " + id + " canceled successfully");
        }
    }

}
