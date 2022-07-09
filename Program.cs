using Arthes2022.Data;
using Arthes2022.Data.Implementation;
using Arthes2022.Data.Interface;
using Arthes2022.Data.Mappings;
using Arthes2022.Data.Repository;
using Arthes2022.Models.Validators;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers()
    .AddFluentValidation(f =>
    {
        f.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");

        f.RegisterValidatorsFromAssemblyContaining<RevistaViewModelValidator>();

    });

builder.Services.AddAutoMapper(typeof(CadastroRevistaMappingProfile));

builder.Services.AddDbContext<ArthesContext>(options => options.UseSqlServer(builder.
    Configuration.GetConnectionString("ArthesDbConn")));


builder.Services.AddScoped<IRevistaManager, RevistaManager>();
builder.Services.AddScoped<IRevistaRepository, RevistaRepository>();

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
