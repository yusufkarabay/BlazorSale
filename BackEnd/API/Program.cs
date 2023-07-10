using Business.Interfaces;
using Business.Managers;
using Core.DB.Helper;
using DataAccess.DAL.NH;
using DataAccess.Helpers;
using DataAccess.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DAL
builder.Services.AddScoped<ICategoryDal, NHCategoryDal>();
builder.Services.AddScoped<IAuhorityDal, NHAuhorityDal>();
builder.Services.AddScoped<ICityDal, NHCityDal>();
builder.Services.AddScoped<ICustomerDal, NHCustomerDal>();
builder.Services.AddScoped<IEmployeeDal, NHEmployeeDal>();
builder.Services.AddScoped<IProductDal, NHProductDal>();
builder.Services.AddScoped<ISaleDal, NHSaleDal>();
builder.Services.AddScoped<IStockDal, NHStockDal>();
builder.Services.AddScoped<IUserAuthorityDal, NHUserAuthorityDal>();
#endregion


#region Business
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IAuhorityService, AuhorityManager>();
builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<IEmployeeService, EmployeeManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ISaleService, SaleManager>();
builder.Services.AddScoped<IStockService, StockManager>();
builder.Services.AddScoped<IUserAuthorityService, UserAuthorityManager>();
#endregion



#region Configuration
builder.Services.AddScoped<NhibernateHelper, PostgresHelper>();
#endregion


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("https://localhost:7008")
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseExceptionHandler("/error");
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
