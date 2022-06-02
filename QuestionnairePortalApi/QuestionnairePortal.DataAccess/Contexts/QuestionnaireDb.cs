using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using QuestionnairePortal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Contexts
{
    public class QuestionnaireDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=QuestionnaireDb;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<QuestionnaireReplie> QuestionnaireReplies { get; set; }



    }
}
