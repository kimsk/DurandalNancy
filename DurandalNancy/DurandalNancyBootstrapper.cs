using Nancy;
using Nancy.Conventions;

namespace DurandalNancy
{
    public class DurandalNancyBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            nancyConventions.StaticContentsConventions
                .Add(StaticContentConventionBuilder.AddDirectory("Scripts", "Scripts"));
            nancyConventions.StaticContentsConventions
                .Add(StaticContentConventionBuilder.AddDirectory("App", "App"));
            nancyConventions.StaticContentsConventions
                .Add(StaticContentConventionBuilder.AddDirectory("Assets", "Assets"));
        }
    }
}