using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var worker = builder.AddProject<Worker>("Worker");

var app = builder.AddProject<Web>("Web")
    .WaitForCompletion(worker);

builder.Build().Run();
