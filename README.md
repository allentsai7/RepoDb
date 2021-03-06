<p align="center">
	<a href="http://repodb.net">
		<img src="https://raw.githubusercontent.com/mikependon/RepoDb.Raw/master/Icons/RepoDb-64x64.png" height="64px" />
	</a>
</p>

-----------------

[![SolutionBuilds](https://img.shields.io/appveyor/ci/mikependon/repodb-h87g9?label=sln%20builds)](https://ci.appveyor.com/project/mikependon/repodb-h87g9)
[![CoreVersion](https://img.shields.io/nuget/v/RepoDb)](https://www.nuget.org/packages/RepoDb)
[![Releases](https://img.shields.io/badge/releases-core-important)](http://repodb.net/release/core)
[![CoreUnitTests](https://img.shields.io/appveyor/tests/mikependon/repodb-yf1cx?label=unit%20tests)](https://ci.appveyor.com/project/mikependon/repodb-yf1cx/build/tests)
[![CoreIntegrationTests](https://img.shields.io/appveyor/tests/mikependon/repodb-qksas?label=integration%20tests)](https://ci.appveyor.com/project/mikependon/repodb-qksas/build/tests)
[![GitterChat](https://img.shields.io/gitter/room/mikependon/RepoDb?color=48B293)](https://gitter.im/RepoDb/community)

# [RepoDb](http://repodb.net) - a hybrid ORM Library for .NET.

RepoDb is an open-source .NET ORM that bridge the gaps between micro-ORMs and full-ORMs. It helps the developer to simplify the switch-over of when to use the BASIC and ADVANCE operations during the development.

It is the best alternative ORM to both Dapper and EntityFramework.

### It is easy-to-use

RepoDb operations were implemented as extended methods of IDbConnection object. For as long the connection is open, any operations can then be called against the database.

### It is high-performant

RepoDb has its own compiler and pre-caches the already-generated compiled expressions for future reusabilities. It understands your schema to create the most optimal compiled expression AOT.

### It is efficient

RepoDb extracts and caches the object properties, execution contexts, object mappings and SQL statements. It is reusing them all throughout the process of transformations and executions.

### It is high-quality

RepoDb is a high-quality micro-ORM supported by 10K+ real-life Unit and Integration Tests. It is highly tested and used by various critical systems that are running in the Production

## Get Started

Please click any of the link below to fast-track your learnings.

- [SqlServer](http://repodb.net/tutorial/get-started-sqlserver)
- [SqLite](http://repodb.net/tutorial/get-started-sqlite)
- [MySql](http://repodb.net/tutorial/get-started-mysql)
- [PostgreSql](http://repodb.net/tutorial/get-started-postgresql)

Or, learn a specific feature.

- [Batch Operations](http://repodb.net/feature/batchoperations)
- [Bulk Operations](http://repodb.net/feature/bulkoperations)
- [Caching](http://repodb.net/feature/caching)
- [Class Mapping](http://repodb.net/feature/classmapping)
- [Dynamics](http://repodb.net/feature/dynamics)
- [Connection Persistency](http://repodb.net/feature/connectionpersistency)
- [Enumeration](http://repodb.net/feature/enumeration)
- [Expression Trees](http://repodb.net/feature/expressiontrees)
- [Hints](http://repodb.net/feature/hints)
- [Implicit Mapping](http://repodb.net/feature/implicitmapping)
- [Multiple Query](http://repodb.net/feature/multiplequery)
- [Property Handlers](http://repodb.net/feature/propertyhandlers)
- [Repositories](http://repodb.net/feature/repositories)
- [Tracing](http://repodb.net/feature/tracing)
- [Transaction](http://repodb.net/feature/transaction)
- [Type Mapping](http://repodb.net/feature/typemapping)

Otherwise, please visit our [documentation](http://repodb.net/docs) page to learn more.

## Supported Databases

The execute methods below supports all RDBMS data providers.

- [ExecuteQuery](http://repodb.net/operation/executequery)
- [ExecuteNonQuery](http://repodb.net/operation/executenonquery)
- [ExecuteScalar](http://repodb.net/operation/executescalar)
- [ExecuteReader](http://repodb.net/operation/executereader)
- [ExecuteQueryMultiple](http://repodb.net/operation/executequerymultiple)

Whereas the fluent methods below only supports the [SQL Server](https://www.nuget.org/packages/RepoDb.SqlServer), [SQLite](https://www.nuget.org/packages/RepoDb.SqLite), [MySQL](https://www.nuget.org/packages/RepoDb.MySql) and [PostgreSQL](https://www.nuget.org/packages/RepoDb.PostgreSql) RDBMS data providers.

- [Query](http://repodb.net/operation/query)
- [Insert](http://repodb.net/operation/insert)
- [Merge](http://repodb.net/operation/merge)
- [Delete](http://repodb.net/operation/delete)
- [Update](http://repodb.net/operation/update)
 
Click [here](http://repodb.net/docs#operations) to see all the operations.

## Benchmark

The benchmark result to be shown on this page will always be referring to the community-approved ORM bencher tool (the [RawDataAccessBencher](https://github.com/FransBouma/RawDataAccessBencher) tool). Results below is the actual recent official execution [result](https://github.com/FransBouma/RawDataAccessBencher/blob/master/Results/20200410_netcore31.txt).

<img src="https://raw.githubusercontent.com/mikependon/RepoDb.NET/master/assets/backgrounds/statistics.png" />

## Contributions

We would like to make RepoDb the mainstream hybrid-ORM library for .NET technology. Please help us build and realize the solution.

To contribute, please find a [for-grabs](https://github.com/mikependon/RepoDb/issues?q=is%3Aissue+is%3Aopen+label%3A%22for+grabs%22) item and issue a PR. Otherwise, please create a [new issue](https://github.com/mikependon/RepoDb/issues/new) for us to look-at and discuss.
If you wish to contribute to the documentation site, it is hosted in the [RepoDb.NET](https://github.com/mikependon/RepoDb.NET) repository.

Your biggest contribution is to utilize and share this solution to other developers.

- Blog it
- Discuss it
- Document it
- Share it
- Use it

Or, show support by simply giving a :star: on this project.

### Engagements

Please get in touch with us via:

- [GitHub](https://github.com/mikependon/RepoDb/issues) - for any issues, requests and problems.
- [StackOverflow](https://stackoverflow.com/search?tab=newest&q=RepoDb) - for any technical questions.
- [Twitter](https://twitter.com/search?q=%23repodb) - for the latest news.
- [Gitter Chat](https://gitter.im/RepoDb/community) - for direct and live Q&A.

### Hints

- [Building the Solutions](https://github.com/mikependon/RepoDb/tree/master/RepoDb.Docs/Building%20the%20Solutions.md) - let us build your copies.
- [Coding Standards](https://github.com/mikependon/RepoDb/tree/master/RepoDb.Docs/Coding%20Standards.md) - let us be uniformed.
- [Issuing a PR](https://github.com/mikependon/RepoDb/tree/master/RepoDb.Docs/Issuing%20a%20PR.md) - let us be aligned and notified.
- [Reporting an Issue](https://github.com/mikependon/RepoDb/tree/master/RepoDb.Docs/Reporting%20an%20Issue.md) - let us be organized for easy tracking and fixing.

## Credits

Thank you to all the [contributors](https://github.com/mikependon/RepoDb/graphs/contributors) of this project, and to [Scott Hanselman](https://www.hanselman.com/) for [Exploring the .NET open source hybrid ORM library RepoDB](https://www.hanselman.com/blog/ExploringTheNETOpenSourceHybridORMLibraryRepoDB.aspx).

And also, thank you to these awesome OSS projects.

- [AppVeyor](https://www.appveyor.com/) - for the builds and test-executions.
- [GitHub](https://github.com/) - for hosting this project.
- [Gitter](https://gitter.im/) - for the community engagements.
- [Jekyll](https://github.com/jekyll/jekyll) - for powering our website.
- [Moq](https://github.com/moq/moq4) - for being the tests mocking framework.
- [Nuget](https://www.nuget.org/) - for the package deliveries.
- [RawDataAccessBencher](https://github.com/FransBouma/RawDataAccessBencher) - for measuring the performance and efficiency.
- [ReadTheDocs](https://readthedocs.org/) - for the library documentations.
- [SharpLab](https://sharplab.io/) - for helping us on our IL coding.
- [Shields](https://shields.io/) - for the awesome badges.
- [StackEdit](https://stackedit.io) - for being the markdown file editor.
- [System.Data.SQLite](https://www.nuget.org/packages/System.Data.SQLite/), [MySql.Data](https://www.nuget.org/packages/MySql.Data/), [MySqlConnector](https://www.nuget.org/packages/MySqlConnector/), [Npgsql](https://www.nuget.org/packages/Npgsql/) - for being the extended DB provider drivers.

## License

[Apache-2.0](http://apache.org/licenses/LICENSE-2.0.html) - Copyright © 2019 - Michael Camara Pendon
