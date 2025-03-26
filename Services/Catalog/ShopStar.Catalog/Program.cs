using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using ShopStar.Catalog.Services.AboutServices;
using ShopStar.Catalog.Services.BrandServices;
using ShopStar.Catalog.Services.CategoryServices;
using ShopStar.Catalog.Services.FeatureDefaultServices;
using ShopStar.Catalog.Services.FeatureSliderServices;
using ShopStar.Catalog.Services.OfferDiscountServices;
using ShopStar.Catalog.Services.ProductDetailServices;
using ShopStar.Catalog.Services.ProductImageServices;
using ShopStar.Catalog.Services.ProductServices;
using ShopStar.Catalog.Services.SpecialOfferServices;
using ShopStar.Catalog.Settings;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "ResourceCatalog";
    opt.RequireHttpsMetadata = false;
   
});

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductDetailService, ProductDetailService>();
builder.Services.AddScoped<IProductImageService,ProductImageService>();
builder.Services.AddScoped<IFeatureSliderService,FeatureSliderService>();
builder.Services.AddScoped<ISpecialOfferService,SpecialOfferService>();
builder.Services.AddScoped<IFeatureDefaultService,FeatureDefaultService>();
builder.Services.AddScoped<IOfferDiscountService,OfferDiscountService>();
builder.Services.AddScoped<IBrandService,BrandService>();
builder.Services.AddScoped<IAboutService,AboutService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
