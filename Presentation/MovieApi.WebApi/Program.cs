using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.UserRegisterHandlers;
using MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers;
using MovieApi.Persistence.Context;
using MovieApi.Persistence.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Registirations
builder.Services.AddDbContext<MovieContext>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();

builder.Services.AddScoped<GetMovieQueryHandler>();
builder.Services.AddScoped<GetMovieByIdQueryHandler>();
builder.Services.AddScoped<CreateMovieCommandHandler>();
builder.Services.AddScoped<RemoveMovieCommandHandler>();
builder.Services.AddScoped<UpdateMovieCommandHandler>();

builder.Services.AddScoped<CreateUserRegisterCommandHandler>();
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<MovieContext>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetTagQueryHandler).Assembly));
#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=> 
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Movie API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Movie API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
