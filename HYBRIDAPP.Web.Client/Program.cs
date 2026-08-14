using HYBRIDAPP.Shared.Interfaces;
using HYBRIDAPP.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FluentValidation;
using HYBRIDAPP.Shared.DTOs;
using HYBRIDAPP.Shared.Validators;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services
builder.Services.AddSingleton<IFormFactor, FormFactor>();

// Add the Validators so the WebAssembly runtime can find them
builder.Services.AddScoped<IValidator<CreateUserDto>, CreateUserDtoValidator>();
builder.Services.AddScoped<IValidator<UpdateUserDto>, UpdateUserDtoValidator>();

// Note: If your Users page also needs IUserService on the client side, 
// you must register a Client-side version of that service here as well.
// builder.Services.AddScoped<IUserService, ClientUserService>();

await builder.Build().RunAsync();