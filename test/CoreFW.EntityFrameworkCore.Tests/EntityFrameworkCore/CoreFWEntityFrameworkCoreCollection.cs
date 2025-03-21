using Xunit;

namespace CoreFW.EntityFrameworkCore;

[CollectionDefinition(CoreFWTestConsts.CollectionDefinitionName)]
public class CoreFWEntityFrameworkCoreCollection : ICollectionFixture<CoreFWEntityFrameworkCoreFixture>
{

}
