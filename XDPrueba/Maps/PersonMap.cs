using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XDPrueba.Models.BDFolder;

namespace XDPrueba.Maps
{
    public class PersonMap
    {
        public PersonMap(EntityTypeBuilder<Person> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("person");

            //entityBuilder.Property(x => x.Id).HasColumnName("id");
            //entityBuilder.Property(x => x.FirstName).HasColumnName("firstname");
            //entityBuilder.Property(x => x.LastName).HasColumnName("lastname");
            //entityBuilder.Property(x => x.CompanyName).HasColumnName("companyname");
            //entityBuilder.Property(x => x.Id).HasColumnName("id");
            //entityBuilder.Property(x => x.Id).HasColumnName("id");
            //entityBuilder.Property(x => x.Id).HasColumnName("id");
            //entityBuilder.Property(x => x.Id).HasColumnName("id");
            //entityBuilder.Property(x => x.Id).HasColumnName("id");
        }
    }
}
