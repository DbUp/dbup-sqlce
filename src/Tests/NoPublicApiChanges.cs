#if !NETCORE
using DbUp.Tests.Common;

namespace DbUp.SqlCe.Tests;

public class NoPublicApiChanges : NoPublicApiChangesBase
{
    public NoPublicApiChanges()
        : base(typeof(SqlCeExtensions).Assembly)
    {
    }
}
#endif
