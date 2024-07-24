[![GitHub Workflow Status (branch)](https://img.shields.io/github/actions/workflow/status/DbUp/dbup-sqlce/main.yml?branch=main)](https://github.com/DbUp/dbup-sqlce/actions/workflows/main.yml?query=branch%3Amain)
[![NuGet](https://img.shields.io/nuget/dt/dbup-sqlce.svg)](https://www.nuget.org/packages/dbup-sqlce)
[![NuGet](https://img.shields.io/nuget/v/dbup-sqlce.svg)](https://www.nuget.org/packages/dbup-sqlce)
[![Prerelease](https://img.shields.io/nuget/vpre/dbup-sqlce?color=orange&label=prerelease)](https://www.nuget.org/packages/dbup-sqlce)

# DbUp SQL CE Support
> [!WARNING]
> This provider is End of Life and will no longer be maintained or supported.
> 
> Microsoft [ended extended support in July 2021](https://en.wikipedia.org/wiki/SQL_Server_Compact).

# Known Issues / Quirks

## Semi-colon Delimiter in multi statement scripts

The delimiter in a multi statement script should be on a new-line. I.e:

```sql
ALTER TABLE "MyTable" ADD "foo" int default null
;

ALTER TABLE "MyTable" ADD "bar" int default null
;
```


## Development

For successful unit testing install

- SQL Server Compact 4.0 SP1 https://www.microsoft.com/en-us/download/details.aspx?id=30709