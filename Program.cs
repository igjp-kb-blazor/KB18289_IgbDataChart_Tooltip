using IgniteUI.Blazor.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddIgniteUIBlazor(
                typeof(IgbLegendModule),
                typeof(IgbDataChartCoreModule),
                typeof(IgbDataChartCategoryModule),
                typeof(IgbDataChartCategoryCoreModule),
                typeof(IgbDataChartInteractivityModule),
                typeof(IgbDataChartAnnotationModule),
                typeof(IgbDataChartStackedModule),
                typeof(IgbStackedFragmentSeriesModule)
            );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapStaticAssets();

app.UseRouting();

app.MapBlazorHub();
app.MapRazorPages().WithStaticAssets();
app.MapFallbackToPage("/_Host");

app.Run();
