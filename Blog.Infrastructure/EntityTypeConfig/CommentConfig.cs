using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Infrastructure.EntityTypeConfig
{
    internal class CommentConfig : BaseEntityConfig<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.AppUser)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.AppUserID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Post)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.PostID)
                   .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
