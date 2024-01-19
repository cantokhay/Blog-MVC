using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Infrastructure.EntityTypeConfig
{
    internal class LikeConfig : BaseEntityConfig<Like>
    {
        public override void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.AppUser)
                   .WithMany(x => x.Likes)
                   .HasForeignKey(x => x.AppUserID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Post)
                   .WithMany(x => x.Likes)
                   .HasForeignKey(x => x.PostID)
                   .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
