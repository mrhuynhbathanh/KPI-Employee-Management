using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.FluentUI.AspNetCore.Components;
using KPIEmployeeManagement.Data.Context;
using KPIEmployeeManagement.Data.Repositories;
using KPIEmployeeManagement.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add Services
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Add Fluent UI
builder.Services.AddFluentUIComponents();

// Add Database Context
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<KpiDbContext>(options =>
    options.UseOracle(connectionString));

// Add Repositories
builder.Services.AddScoped<IKpiEmployeeRepository, KpiEmployeeRepository>();
builder.Services.AddScoped<IKpiEmployeeService, KpiEmployeeService>();

var host = builder.Build();
await host.RunAsync();
