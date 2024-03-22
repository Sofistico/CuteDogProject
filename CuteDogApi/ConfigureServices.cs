namespace CuteDogApi
{
    public static class ConfigureServices
    {
        public static void ConfigureSender(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblies(typeof(ConfigureServices).Assembly);
            });
        }
    }
}
