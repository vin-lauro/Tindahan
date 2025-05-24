namespace API.Extensions;

public static class ServicesExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
            options.AddPolicy(
                "CorsPolicy",
                policy =>
                policy.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin()
                ));


}