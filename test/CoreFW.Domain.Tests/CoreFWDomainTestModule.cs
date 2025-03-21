using Volo.Abp.Modularity;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWDomainModule),
    typeof(CoreFWTestBaseModule)
)]
public class CoreFWDomainTestModule : AbpModule
{

}
