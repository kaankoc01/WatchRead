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

// Veri taban� ba�lant�s�(�rne�in SQL Server)
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Genel servis ve repository eklemeleri
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));

// Category i�in �zel eklemeler
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

// Comment i�in �zel eklemeler
builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentDal>();

// Content i�in �zel eklemeler
builder.Services.AddScoped<IContentService, ContentManager>();
builder.Services.AddScoped<IContentDal, EfContentDal>();

// ContentGenre i�in �zel eklemeler
builder.Services.AddScoped<IContentGenreService, ContentGenreManager>();
builder.Services.AddScoped<IContentGenreDal, EfContentGenreDal>();

// Favorite i�in �zel eklemeler
builder.Services.AddScoped<IFavoriteService, FavoriteManager>();
builder.Services.AddScoped<IFavoriteDal, EfFavoriteDal>();

// Genre i�in �zel eklemeler
builder.Services.AddScoped<IGenreService, GenreManager>();
builder.Services.AddScoped<IGenreDal, EfGenreDal>();

// Rating i�in �zel eklemeler
builder.Services.AddScoped<IRatingService, RatingManager>();
builder.Services.AddScoped<IRatingDal, EfRatingDal>();

// Role i�in �zel eklemeler
builder.Services.AddScoped<IRoleService, RoleManager>();
builder.Services.AddScoped<IRoleDal, EfRoleDal>();

// User i�in �zel eklemeler
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();

// UserRole i�in �zel eklemeler
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
