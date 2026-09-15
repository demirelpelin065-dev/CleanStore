# CleanStore

CleanStore is an ASP.NET Core Web API built for a .NET Backend assignment.

## Clean Architecture

The solution contains four layers:
- CleanStore.API
- CleanStore.Application
- CleanStore.Domain
- CleanStore.Infrastructure

Dependencies point inward toward the Domain layer.

## Technologies
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server LocalDB
- MediatR
- CQRS
- Repository Pattern
- Swagger

## Entities

The application contains two related entities:

### Category
A Category can contain many Products.

### Product
A Product belongs to one Category.

This creates a one-to-many relationship between Category and Product.

## CQRS and MediatR

Commands:
- CreateProductCommand
- UpdateProductCommand
- DeleteProductCommand

Queries:
- GetAllProductsQuery
- GetProductByIdQuery

Controllers use MediatR to send Commands and Queries to their handlers.

## Repository Pattern

IRepository is defined in the Domain layer.
Repository is implemented in the Infrastructure layer using Entity Framework Core.

## Database

The project uses SQL Server LocalDB.
Database name: CleanStoreDb

EF Core migrations are stored in CleanStore.Infrastructure/Migrations.

## API Endpoints

- GET /api/Products
- GET /api/Products/{id}
- POST /api/Products
- PUT /api/Products/{id}
- DELETE /api/Products/{id}

## Run the API

dotnet run --project .\CleanStore.API

Swagger is available at:
http://localhost:5115/swagger

The port may differ depending on the development environment.

## GitHub Workflow

The main branch is protected.
Development is done using feature branches and Pull Requests.
