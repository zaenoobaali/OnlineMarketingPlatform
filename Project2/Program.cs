using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Project2.Model;
using Project2.Repository.Interfaces;
using Project2.Repository.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProfileService, ProfileService>();
builder.Services.AddScoped<IMarketerService, MarketerService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IPostServices, PostServices>();
builder.Services.AddScoped<INotifyServices, NotifyServices>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IComplaintService, ComplaintService>();
builder.Services.AddScoped<IDeliverService, DeliverService>();
builder.Services.AddScoped<IPopularizationService, PopularizationService>();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddHttpContextAccessor();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "https://localhost:7242/",
            ValidAudience = "https://localhost:7242/",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("veryVerySecretKey"))
        };
    });
//builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
//{
//    builder.AllowAnyMethod()
//           .AllowAnyHeader()
//           .SetIsOriginAllowed(origin => true)
//           .AllowCredentials();
//}));

builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});
var app = builder.Build();

//app.UseCors(option => option.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());
//app.UseCors("CorsPolicy");
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
