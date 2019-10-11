using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRC.Portal.Data.Domains;

namespace FRC.Portal.Data
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("portal_DB") { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Alumni> Alumni { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<CommitteeMember> CommitteeMembers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<VIP> VIPs { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<VolunteerRole> VolunteerRoles { get; set; }
    }
}
