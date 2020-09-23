using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Blazing Orchard",
    Author = "Sipke Schoorstra",
    Website = "https://github.com/BlazingOrchard/BlazingOrchard.OrchardCoreModule",
    Version = "1.0.0",
    Description = "Provides API endpoints to Blazor applications using the Blazing Orchard client-side framework.",
    Category = "Blazor",
    Dependencies = new[] { "OrchardCore.Contents" }
)]