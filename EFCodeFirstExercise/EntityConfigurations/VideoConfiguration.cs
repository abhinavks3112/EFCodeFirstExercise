using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EFCodeFirstExercise;

namespace EFCodeFirstExistingDatabase.EntityConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(v => v.Classification)
                 .HasColumnType("tinyint");

            HasRequired(v => v.Genre)
                .WithMany(g => g.Videos)
                .HasForeignKey(v => v.GenreId);
        }
        
    }
}
