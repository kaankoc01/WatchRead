using AutoMapper;
using WatchRead.EntityLayer.Concrete;
using WatchRead.DtoLayer.DTOs.UserDto;
using WatchRead.DtoLayer.DTOs.RoleDto;
using WatchRead.DtoLayer.DTOs.RatingDto;
using WatchRead.DtoLayer.DTOs.GenreDto;
using WatchRead.DtoLayer.DTOs.FavoriteDto;
using WatchRead.DtoLayer.DTOs.CommentDto;
using WatchRead.DtoLayer.DTOs.CategoryDto;
using WatchRead.DtoLayer.DTOs.ContentDto;
using WatchRead.DtoLayer.DTOs.ContentGenreDto;
using WatchRead.DtoLayer.DTOs.UserRoleDto;



namespace WatchRead.BusinessLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Örnek dönüşümler
            // Category
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            // Comment
            CreateMap<Comment, ResultCommentDto>().ReverseMap();
            CreateMap<Comment, CreateCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();

            // Content
            CreateMap<Content, ResultContentDto>().ReverseMap();
            CreateMap<Content, CreateContentDto>().ReverseMap();
            CreateMap<Content, UpdateContentDto>().ReverseMap();

            // ContentGenre
            CreateMap<ContentGenre, ContentGenreDto>().ReverseMap();


            // Favorite
            CreateMap<Favorite, ResultFavoriteDto>().ReverseMap();
            CreateMap<Favorite, CreateFavoriteDto>().ReverseMap();
            CreateMap<Favorite, UpdateFavoriteDto>().ReverseMap();

            // Genre
            CreateMap<Genre, ResultGenreDto>().ReverseMap();
            CreateMap<Genre, CreateGenreDto>().ReverseMap();
            CreateMap<Genre, UpdateGenreDto>().ReverseMap();

            // Rating
            CreateMap<Rating, ResultRatingDto>().ReverseMap();
            CreateMap<Rating, CreateRatingDto>().ReverseMap();
            CreateMap<Rating, UpdateRatingDto>().ReverseMap();

            // Role
            CreateMap<Role, ResultRoleDto>().ReverseMap();
            CreateMap<Role, CreateRoleDto>().ReverseMap();
            CreateMap<Role, UpdateRoleDto>().ReverseMap();

            // User
            CreateMap<User, ResultUserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();

            // UserRole
            CreateMap<UserRole, UserRoleDto>().ReverseMap();
            // Diğer dönüşümleri burada tanımlayın
        }
    }
}
