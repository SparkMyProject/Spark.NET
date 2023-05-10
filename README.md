
# Spark.NET
A new way to create .NET projects with ease.




## Features

- A 3-in-1 solution solving all your problems with integrating projects.
- Includes a separate API
- Separate Data and Infrastructure projects
- JSON Web Token support
- Identity support integrated with JSON Web Tokens.
- Already setup ApplicationDBContext
- Multi-DB support with easy ways to switch
  - Microsoft SQL(and LocalDB)
  - MySQL and MariaDB
  - PostgreSQL
  - SQLite
  - And more!
- Docker Support for quick & easy deployment(installation directions below)
- Well documented and easy-to-understand
- Popular 3rd party integrations such as
  - Swagger, for API docmentation
  -
- Custom service implementation, allowing seamless startup
- Multi-project service initialization and configuration
  - Done in the Infrastructure project, to allow a dependency
- Cross platform


## Configuration

Spark.NET is setup to be highly customizable. With that being said, there is a certain way to go about it.

For logging, the project uses Serilog. The .API project uses the AspNetCore Sink, while the rest use the normal Serilog.

The configurations for each are as follows:
- .API, Program.cs
- .Shared.Infrastructure, ServiceStartup.ConfigureInfrastructureLogger()


## Installation

Install my-project with npm

```bash
  npm install my-project
  cd my-project
```
    