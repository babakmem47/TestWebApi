using WebApiTest.Models;
using System.Data.Entity.ModelConfiguration;

namespace WebApiTest.EntityConfigurations
{
    public class AttendanceConfiguration : EntityTypeConfiguration<Attendance>
    {
        public AttendanceConfiguration()
        {
            //            HasKey(at => at.AttendeeId).HasKey(at => at.GigId);

            //            Property(at => at.AttendeeId)
            //                .IsRequired();
            //
            //            Property(at => at.GigId)
            //                .IsRequired();

            //// Relation with Gig ////
            HasRequired(at => at.Gig)
                .WithMany()
                .WillCascadeOnDelete(false);


        }
    }
}