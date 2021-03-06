# Cars

Notes on how this project is being built...

- Created new WPF desktop project targeting .NET Core
- Added Prism, MahApps and MaterialDesign
- Added new Core .NET Standard project to hold the data model
- Created class / database diagram using Dia
- Started on UI screen mockups in Pencil

- Should have created a new Prism solution for using the Prism Full App (.NET Core) template from https://marketplace.visualstudio.com/items?itemName=BrianLagunas.PrismTemplatePack
- Used the DryIOC container
- Added entities
- Installed NSwagStudio
- Created ASP.NET Core project
- Generate C# client through NSwagStudio, gnerating output only (not to file)
- Copy parts of generated code to different projects (Models, Interfaces)
- Build views and navigation
- Installed EF Core and EF Core SQL Server and added application db context with model configuration
- Added migrations and generated database
- Seed database with dummy data using Bogus


# Architecture Notes

- Create Prism modules SearchModule, ComparisonModule, FavouritesModule
- Add Entities to core
- Add Entity Framework to Services project
