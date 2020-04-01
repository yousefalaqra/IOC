using Autofac;

public static class Configration
{
    public static IContainer Configure(){
        var builder =  new ContainerBuilder();

        builder
        .RegisterGeneric(typeof(Repository<>))
        .As(typeof(IRepository<>))
        .InstancePerDependency();

        builder
        .RegisterType<Application>()
        .As<IApplication>();

        builder
        .RegisterType<Manager>()
        .As<IManager>();

        builder
        .RegisterType<Logger>()
        .As<ILogger>();

        return builder.Build();
    }
}