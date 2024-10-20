using FinalProjectPRN231.API;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build().ConfigurePipeline();
Log.Logger.Error("Start API");
app.Run();
