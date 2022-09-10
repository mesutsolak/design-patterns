public static class ServiceCollectionContainerBuilderExtensions
{
    public static IServiceCollection AddBasicCqrs(this IServiceCollection services)
    {
        services.AddTransient<AddProductCommandHandler>();
        services.AddTransient<RemoveProductCommandHandler>();
        services.AddTransient<UpdateProductCommandHandler>();
        services.AddTransient<GetAllProductQueryHandler>();
        services.AddTransient<GetByIdProductQueryHandler>();

        return services;
    }
}