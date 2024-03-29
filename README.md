[![GitHub Workflow Status (branch)](https://img.shields.io/github/actions/workflow/status/DbUp/dbup-sqlce/main.yml?branch=main)](https://github.com/DbUp/dbup-sqlce/actions/workflows/main.yml?query=branch%3Amain)
[![NuGet](https://img.shields.io/nuget/dt/dbup-sqlce.svg)](https://www.nuget.org/packages/dbup-sqlce)
[![NuGet](https://img.shields.io/nuget/v/dbup-sqlce.svg)](https://www.nuget.org/packages/dbup-sqlce)
[![Prerelease](https://img.shields.io/nuget/vpre/dbup-sqlce?color=orange&label=prerelease)](https://www.nuget.org/packages/dbup-sqlce)

# DbUp SQL CE Support

DbUp is a .NET library that helps you to deploy changes to SQL Server databases. It tracks which SQL scripts have been
run already, and runs the change scripts that are needed to get your database up to date.

## Getting Help

To learn more about DbUp check out the [documentation](https://dbup.readthedocs.io/en/latest/)

Please only log issue related to SQL CE Support in this repo. For cross cutting issues, please use
our [main issue list](https://github.com/DbUp/DbUp/issues).

# Contributing

See the [readme in our main repo](https://github.com/DbUp/DbUp/blob/master/README.md) for how to get started and
contribute.

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