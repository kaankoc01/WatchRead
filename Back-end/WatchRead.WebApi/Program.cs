using Microsoft.AspNetCore.Hosting.Server;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WatchRead.BusinessLayer.Abstract;
using WatchRead.BusinessLayer.Concrete;
using WatchRead.BusinessLayer.Mapping;
using WatchRead.DataAccessLayer.Abstract;
using WatchRead.DataAccessLayer.Concrete;
using WatchRead.DataAccessLayer.EntityFramework;
using WatchRead.DataAccessLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Veri tabaný baðlantýsý(örneðin SQL Server)
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Genel servis ve repository eklemeleri
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));

// Category için özel eklemeler
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

// Comment için özel eklemeler
builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentDal>();

// Content için özel eklemeler
builder.Services.AddScoped<IContentService, ContentManager>();
builder.Services.AddScoped<IContentDal, EfContentDal>();

// ContentGenre için özel eklemeler
builder.Services.AddScoped<IContentGenreService, ContentGenreManager>();
builder.Services.AddScoped<IContentGenreDal, EfContentGenreDal>();

// Favorite için özel eklemeler
builder.Services.AddScoped<IFavoriteService, FavoriteManager>();
builder.Services.AddScoped<IFavoriteDal, EfFavoriteDal>();

// Genre için özel eklemeler
builder.Services.AddScoped<IGenreService, GenreManager>();
builder.Services.AddScoped<IGenreDal, EfGenreDal>();

// Rating için özel eklemeler
builder.Services.AddScoped<IRatingService, RatingManager>();
builder.Services.AddScoped<IRatingDal, EfRatingDal>();

// Role için özel eklemeler
builder.Services.AddScoped<IRoleService, RoleManager>();
builder.Services.AddScoped<IRoleDal, EfRoleDal>();

// User için özel eklemeler
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();

// UserRole için özel eklemeler
builder.Services.AddScoped<IUserRoleService, UserRoleManager>();
builder.Services.AddScoped<IUserRoleDal, EfUserRoleDal>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
