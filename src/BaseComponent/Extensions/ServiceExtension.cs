using Microsoft.Extensions.DependencyInjection;

namespace FluentUI.Extensions
{
    public static class ServiceExtension
    {
        public static void AddFluentUI(this IServiceCollection services)
        {
            services.AddScoped<IComponentStyle, ComponentStyle>();
            services.AddScoped<ThemeProvider>();
            services.AddScoped<ScopedStatics>();
            services.AddScoped<LayerHostService>();
        }
    }
}