# WebApi/Backend Exercise

## Overview
This is a very basic webapi accepts data/records and stores them in a SQL Azure Database.  It utilizes Azure App Services and an SQL Azure Database and is capable of running on Azure free services/subscriptions

## Technologies
- ASP.NET Core 8 Web Api
- Entity Framework Core
- SQL Azure

## Additional Information
 - Utilized EF Migrations to create DB table
 - Was developed using Visual Studio Code
 - Includes Swagger Config

Full working sample can be viewed utilizing Swagger UI - https://keypath-b7fabrhugdewdrad.australiaeast-01.azurewebsites.net/swagger

## Limitations
There are many limitation due to specific time contraints that should be noted
 - Azure App Services have been used for simplicity, would alternatively use Azure Functions (http endpoint) for scalability, cost benfits etc
 - Would typically create Azure services using infrustructure as code (bicep) and configure CI/CD
 - No unit/integration tests have been written
 - There is no authentication or use of Azure Vault for database connection strings
 - No monitoring/alerting/insights have been configured
