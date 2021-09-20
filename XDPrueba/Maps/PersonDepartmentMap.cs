using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XDPrueba.Models.BDFolder;

namespace XDPrueba.Maps
{
    public class PersonDepartmentMap
    {
        public PersonDepartmentMap(EntityTypeBuilder<PersonDepartment> entityBuilder)
        {
            entityBuilder.HasKey(x => x.DepartmentId);
            entityBuilder.ToTable("persondepartment");

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

