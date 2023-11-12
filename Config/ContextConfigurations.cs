using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using UBSDigital.Context;

namespace UBSDigital.Config;

public static class ContextConfigurations
{
    public static void AddContextConfiguration(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.ConfigureWarnings(warningsConfigurationBuilder => warningsConfigurationBuilder.Ignore(CoreEventId.PossibleIncorrectRequiredNavigationWithQueryFilterInteractionWarning));
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });

        builder.Services.AddTransient<IAppDbContext, AppDbContext>();
    }
}
