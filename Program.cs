using odataQuery.Models;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Query.Expressions;
using odataQuery.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IProductSaleRepository, ProductSaleInMemoryRespository>();

builder.Services.AddControllers().
    AddOData(opt => 
        opt.EnableQueryFeatures().
            AddRouteComponents("odata", ModelBuilder.GetEdmModel(), 
                services => 
                    // Here you will Apply the Searcbinder
                    services.AddSingleton<ISearchBinder, ProductSalesDataSearchBinder>()));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();