using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Infrastructure.EntityTypeConfig
{
    internal class PostConfig : BaseEntityConfig<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Content).IsRequired();

            builder.HasOne(x => x.Author)
                   .WithMany(x => x.Posts)
                   .HasForeignKey(x => x.AuthorID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Genre)
                   .WithMany(x => x.Posts)
                   .HasForeignKey(x => x.GenreID)
                   .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
