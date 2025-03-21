using Volo.Abp.Modularity;

namespace CoreFW;

public abstract class CoreFWApplicationTestBase<TStartupModule> : CoreFWTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
