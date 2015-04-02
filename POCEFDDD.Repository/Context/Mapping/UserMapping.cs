using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCEFDDD.Model.Entities;

namespace POCEFDDD.context.mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap ()
	    {
            ToTable("Users");

            HasKey(p => p.Id);

            Property(p => p.Name).HasMaxLength(30);
            Property(p => p.Email)
                .HasMaxLength(30);
                //.HasColumnAnnotation(IndexAnnotation.AnnotationName,
                //                      new IndexAnnotation(new IndexAttribute("IX_EMAIL", 1) { IsUnique = true }));
	    }
        
    }
}
