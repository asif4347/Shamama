using System.Data.Entity;

namespace WebPhase2.Models
{
    public class DataBaseConnetion : DbContext
    {
        public DbSet<Applicant> ApplicantDb { get; set; }
        public System.Data.Entity.DbSet<AdminContact> AdminContacts { get; set; }
        public DbSet<HR> hr { get; set; }
    }
}