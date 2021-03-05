Use the following commands to create the database using EF Code-First

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add "Initial" --project Infrastructure\Cars.Infrastructure.csproj --startup-project Server\Cars.WebApi --output-dir Persistence\Migrations
dotnet ef database update  --project Infrastructure\Cars.Infrastructure.csproj --startup-project Server\Cars.WebApi

// For removing a migration:
Run from src folder
dotnet ef migrations remove --project Infrastructure\Cars.Infrastructure.csproj --startup-project Server\Cars.WebApi

// If already applied to the database
dotnet ef database update 0 --project Infrastructure\Cars.Infrastructure.csproj --startup-project Server\Cars.WebApi
