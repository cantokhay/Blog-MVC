using Autofac;
using AutoMapper;
using Blog.Application.AutoMapper;
using Blog.Domain.Repositories.Abstract.AppUserRepos;
using Blog.Domain.Repositories.Abstract.AuthorRepos;
using Blog.Domain.Repositories.Abstract.CommentRepos;
using Blog.Domain.Repositories.Abstract.GenreRepos;
using Blog.Domain.Repositories.Abstract.LikeRepos;
using Blog.Domain.Repositories.Abstract.PostRepos;
using Blog.Infrastructure.Repositories.Concrete.AppUserRepo;
using Blog.Infrastructure.Repositories.Concrete.AuthorRepos;
using Blog.Infrastructure.Repositories.Concrete.CommentRepos;
using Blog.Infrastructure.Repositories.Concrete.GenreRepos;
using Blog.Infrastructure.Repositories.Concrete.LikeRepos;
using Blog.Infrastructure.Repositories.Concrete.PostRepos;
using Blog.Application.Services.Abstract;
using Blog.Application.Services.Concrete;

namespace Blog.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PostReadRepository>().As<IPostReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<PostWriteRepository>().As<IPostWriteRepository>().InstancePerLifetimeScope();
            builder.RegisterType<PostReadService>().As<IPostReadService>().InstancePerLifetimeScope();
            builder.RegisterType<PostWriteService>().As<IPostWriteService>().InstancePerLifetimeScope();

            builder.RegisterType<GenreReadRepository>().As<IGenreReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<GenreWriteRepository>().As<IGenreWriteRepository>().InstancePerLifetimeScope();
            builder.RegisterType<GenreReadService>().As<IGenreReadService>().InstancePerLifetimeScope();
            builder.RegisterType<GenreWriteService>().As<IGenreWriteService>().InstancePerLifetimeScope();

            builder.RegisterType<AuthorReadRepository>().As<IAuthorReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AuthorWriteRepository>().As<IAuthorWriteRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AuthorReadService>().As<IAuthorReadService>().InstancePerLifetimeScope();
            builder.RegisterType<AuthorWriteService>().As<IAuthorWriteService>().InstancePerLifetimeScope();

            builder.RegisterType<LikeReadRepository>().As<ILikeReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<LikeWriteRepository>().As<ILikeWriteRepository>().InstancePerLifetimeScope();
            builder.RegisterType<LikeReadService>().As<ILikeReadService>().InstancePerLifetimeScope();
            builder.RegisterType<LikeWriteService>().As<ILikeWriteService>().InstancePerLifetimeScope();

            builder.RegisterType<CommentReadRepository>().As<ICommentReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CommentWriteRepository>().As<ICommentWriteRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CommentReadService>().As<ICommentReadService>().InstancePerLifetimeScope();
            builder.RegisterType<CommentWriteService>().As<ICommentWriteService>().InstancePerLifetimeScope();

            builder.RegisterType<AppUserReadRepository>().As<IAppUserReadRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserWriteRepository>().As<IAppUserWriteRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserReadService>().As<IAppUserReadService>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserWriteService>().As<IAppUserWriteService>().InstancePerLifetimeScope();

            builder.RegisterType<Mapper>().As<IMapper>().InstancePerLifetimeScope();

            #region AutoMapper //Copy-Paste
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                //Register Mapper Profile
                cfg.AddProfile<Mapping>();
            }
            )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                //This resolves a new context that can be used later.
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
            #endregion

            base.Load(builder);
        }
    }
}
