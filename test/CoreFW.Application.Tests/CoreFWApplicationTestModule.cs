using Volo.Abp.Modularity;

namespace CoreFW;

[DependsOn(
    typeof(CoreFWApplicationModule),
    typeof(CoreFWDomainTestModule)
)]
public class CoreFWApplicationTestModule : AbpModule
{

}
