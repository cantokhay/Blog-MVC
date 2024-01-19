using AutoMapper;
using Blog.Domain.Entities;
using Blog.Models.DTOs.AppUser;
using Blog.Models.DTOs.Author;
using Blog.Models.DTOs.Comment;
using Blog.Models.DTOs.Genre;
using Blog.Models.DTOs.Like;
using Blog.Models.DTOs.Post;
using Blog.Models.VMs;

namespace Blog.Application.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Post, PostCreateDTO>().ReverseMap();
            CreateMap<Post, PostUpdateDTO>().ReverseMap();
            CreateMap<Post, PostVM>().ReverseMap();

            CreateMap<Like, LikeCreateDTO>().ReverseMap();
            CreateMap<Like, LikeUpdateDTO>().ReverseMap();
            CreateMap<Like, LikeVM>().ReverseMap();

            CreateMap<Comment, CommentCreateDTO>().ReverseMap();
            CreateMap<Comment, CommentUpdateDTO>().ReverseMap();
            CreateMap<Comment, CommentVM>().ReverseMap();

            CreateMap<Genre, GenreCreateDTO>().ReverseMap();
            CreateMap<Genre, GenreUpdateDTO>().ReverseMap();
            CreateMap<Genre, GenreVM>().ReverseMap();

            CreateMap<Author, AuthorCreateDTO>().ReverseMap();
            CreateMap<Author, AuthorUpdateDTO>().ReverseMap();
            CreateMap<Author, AuthorVM>().ReverseMap();

            CreateMap<AppUser, LoginDTO>().ReverseMap();
            CreateMap<AppUser, RegisterDTO>().ReverseMap();
            CreateMap<AppUser, UpdateProfileDTO>().ReverseMap();
            CreateMap<AppUser, AppUserVM>().ReverseMap();
        }
    }
}
